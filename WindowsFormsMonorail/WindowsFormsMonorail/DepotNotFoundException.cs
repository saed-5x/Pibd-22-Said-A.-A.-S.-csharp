﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class DepotNotFoundException : Exception
    {
        public DepotNotFoundException(int i) : base("Не найден поезд по месту " + i)
        {

        }
    }
}
