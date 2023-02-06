using Core.Utilities.Result.Abstract;
using Entities.Dtos.TourTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITourTypeService
    {
        Task<IDataResult<TourTypeDto>> GetAsync(int tourTypeId);
        Task<IDataResult<TourTypeListDto>> GetAllAsync();
        Task<IDataResult<TourTypeDto>> AddAsync(TourTypeAddDto tourTypeAddDto);
        Task<IDataResult<TourTypeDto>> UpdateAsync(TourTypeUpdateDto tourTypeUpdateDto);
        Task<IDataResult<TourTypeDto>> DeleteAsync(int tourTypeId);
    }
}
