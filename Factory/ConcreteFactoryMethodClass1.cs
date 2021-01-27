using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ConcreteFactoryMethodClass1: FactoryMethod
    {
        protected override Pizza CriarPizza()
        {
            return new CheesePizza();
        }
    }
}
