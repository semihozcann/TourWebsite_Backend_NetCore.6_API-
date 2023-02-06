using AutoMapper;
using Business.Abstract;
using Business.ValidationRules.FluentValidation.TourTypes;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.ComplexType;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.TourTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TourTypeManager : ITourTypeService
    {
        #region Injection
        private readonly ITourTypeRepository _tourTypeRepository;
        private readonly IMapper _mapper;

        public TourTypeManager(ITourTypeRepository tourTypeRepository, IMapper mapper)
        {
            _tourTypeRepository = tourTypeRepository;
            _mapper = mapper;
        }
        #endregion


        [ValidationAspect(typeof(TourTypeAddValidator))]
        public async Task<IDataResult<TourTypeDto>> AddAsync(TourTypeAddDto tourTypeAddDto)
        {
            var tourType = _mapper.Map<TourType>(tourTypeAddDto);
            var tourTypeAdded = await _tourTypeRepository.AddAsync(tourType);
            await _tourTypeRepository.SaveAsync();
            return new DataResult<TourTypeDto>(ResultStatus.Success, "TourType Added", new TourTypeDto
            {
                TourType = tourType,
                Message = "TourType Added",
                ResultStatus = ResultStatus.Success
            });
            
        }

        public async Task<IDataResult<TourTypeDto>> DeleteAsync(int tourTypeId)
        {
            var tourType = await _tourTypeRepository.GetAsync(t => t.Id == tourTypeId);
            if (tourType != null)
            {
                var deletedTourType = await _tourTypeRepository.DeleteAsync(tourType);
                await _tourTypeRepository.SaveAsync();
                return new DataResult<TourTypeDto>(ResultStatus.Success, "TourType Deleted", new TourTypeDto
                {
                    TourType = deletedTourType,
                    Message = "TourType Deleted",
                    ResultStatus= ResultStatus.Success
                });
            }
            else
            {
                return new DataResult<TourTypeDto>(ResultStatus.Error, "TourType Not Found", new TourTypeDto
                {
                    TourType = null,
                    Message = "TourType Not Found",
                    ResultStatus = ResultStatus.Error
                });
            }
        }

        public async Task<IDataResult<TourTypeListDto>> GetAllAsync()
        {
            var tourTypes = await _tourTypeRepository.GetAllAsync();
            if (tourTypes != null)
            {
                return new DataResult<TourTypeListDto>(ResultStatus.Success, new TourTypeListDto
                {
                    TourTypes = tourTypes,
                    ResultStatus = ResultStatus.Success
                });
            }
            else
            {
                return new DataResult<TourTypeListDto>(ResultStatus.Error, "TourTypes Not Found", new TourTypeListDto
                {
                    TourTypes = null,
                    Message = "TourTypes Not Found",
                    ResultStatus = ResultStatus.Error

                });
            }
        }

        public async Task<IDataResult<TourTypeDto>> GetAsync(int tourTypeId)
        {
            var tourType = await _tourTypeRepository.GetAsync(t => t.Id == tourTypeId);
            if (tourType != null)
            {
                return new DataResult<TourTypeDto>(ResultStatus.Success, new TourTypeDto
                {
                    TourType = tourType,
                    ResultStatus = ResultStatus.Success
                });
            }
            else
            {
                return new DataResult<TourTypeDto>(ResultStatus.Error, "TourType Not Found", new TourTypeDto
                {
                    TourType = null,
                    Message = "TourType Not Found",
                    ResultStatus = ResultStatus.Error

                });
            }
        }


        [ValidationAspect(typeof(TourTypeUpdateValidator))]
        public async Task<IDataResult<TourTypeDto>> UpdateAsync(TourTypeUpdateDto tourTypeUpdateDto)
        {
            var oldTourType = await _tourTypeRepository.GetAsync(t => t.Id == tourTypeUpdateDto.Id);
            var tourType = _mapper.Map<TourTypeUpdateDto, TourType>(tourTypeUpdateDto, oldTourType);
            var updatedTourType = await _tourTypeRepository.UpdateAsync(tourType);
            return new DataResult<TourTypeDto>(ResultStatus.Success, "TourType Updated", new TourTypeDto
            {
                TourType = updatedTourType,
                Message = "TourType Updated",
                ResultStatus = ResultStatus.Success
            });
        }
    }
}
