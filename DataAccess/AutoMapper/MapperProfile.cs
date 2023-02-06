using AutoMapper;
using Entities.Concrete;
using Entities.Dtos.TourTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<TourTypeAddDto, TourType>();
            CreateMap<TourTypeUpdateDto, TourType>();
            CreateMap<TourType, TourTypeUpdateDto>();
        }
    }
}
