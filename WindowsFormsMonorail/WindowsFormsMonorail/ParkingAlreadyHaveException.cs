using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class DepotAlreadyHaveException : Exception
    {
        public DepotAlreadyHaveException() : base("В депо уже есть такой поезд") { }
    }
}
