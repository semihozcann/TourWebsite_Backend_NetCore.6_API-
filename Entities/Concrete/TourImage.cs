using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TourImage : BaseEntity, IEntity
    {
        public int TourId { get; set; }
        public int ImageId { get; set; }

        public virtual Tour Tour { get; set; }
        public virtual Image Image { get; set; }

    }
}
