using DP_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Factory.Classes
{
    class ConcreteProduct2: IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
