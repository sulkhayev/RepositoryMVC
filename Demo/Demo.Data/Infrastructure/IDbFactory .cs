﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Infrastructure
{
   public interface IDbFactory
    {
        DemoEntities Init();
    }
}
