﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Business.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class CounterManager : GenericManager<Counter>, ICounterService
    {
        public CounterManager(DataAccess.Abstract.IGenericDal<Counter> genericDal) : base(genericDal)
        {
        }
    }
}