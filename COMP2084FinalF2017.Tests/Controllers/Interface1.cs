﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2084FinalF2017.Tests.Controllers
{
   
    interface Interface1
    {
        IQueryable<Country> Countries { get; }
        Country Save(Country Country);
        void Delete(Country Country);    }
}
