using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.TourTypes
{
    public class TourTypeListDto : BaseDto
    {
        public IList<TourType> TourTypes { get; set; }
    }
}
