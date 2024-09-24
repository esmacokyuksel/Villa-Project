﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Business.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class SubHeaderManager : GenericManager<SubHeader>, ISubHeaderService
    {
        public SubHeaderManager(DataAccess.Abstract.IGenericDal<SubHeader> genericDal) : base(genericDal)
        {
        }
    }
}