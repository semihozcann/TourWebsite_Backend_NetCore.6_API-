using AutoMapper;
using Business.Abstract;
using Core.Utilities.Result.ComplexType;
using Entities.Concrete;
using Entities.Dtos.TourTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourTypesController : ControllerBase
    {
        private readonly ITourTypeService _tourTypeService;
        private readonly IMapper _mapper;

        public TourTypesController(ITourTypeService tourTypeService, IMapper mapper)
        {
            _tourTypeService = tourTypeService;
            _mapper = mapper;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAsync(TourTypeAddDto tourType)
        {
            var result = await _tourTypeService.AddAsync(tourType);
            if (result.ResultStatus == 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(TourTypeUpdateDto tourType)
        {
            var result = await _tourTypeService.UpdateAsync(tourType);
            if (result.ResultStatus == 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _tourTypeService.GetAllAsync();
            if (result.ResultStatus == 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetAsync(int tourTypeId)
        {
            var result = await _tourTypeService.GetAsync(tourTypeId);
            if (result.ResultStatus == 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
