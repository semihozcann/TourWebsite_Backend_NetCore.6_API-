using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment : BaseEntity, IEntity
    {
        public int TourId { get; set; }
        public int UserId { get; set; }
        public string Details { get; set; }
        public string Point { get; set; }

        public virtual Tour Tour { get; set; }
        public virtual User User { get; set; }
    }
}
