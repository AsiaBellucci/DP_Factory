using DP_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Factory.Classes
{
    class ConcreteProduct1: IProduct
    {
        // Concrete Products provide various implementations of the Product
        // interface.
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
