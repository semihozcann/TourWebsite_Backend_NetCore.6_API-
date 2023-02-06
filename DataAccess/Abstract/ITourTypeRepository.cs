﻿using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITourTypeRepository : IEntityRepository<TourType>
    {

    }
}
