using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tour : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public int TourTypeId { get; set; }
        public int CompanyId { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        public string PickUpTİme { get; set; }
        public string PickUpPlace { get; set; }
        public string ReturnPlace { get; set; }
        public string Description { get; set; }

        public virtual TourType TourType { get; set; }
        public virtual Company Company { get; set; }



    }
}
