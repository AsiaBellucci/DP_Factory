using DP_Factory.Abstracts;
using DP_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Factory.Classes
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }

        
    }
}
