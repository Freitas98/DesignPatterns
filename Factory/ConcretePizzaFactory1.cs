using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ConcretePizzaFactory1: AbstractFactory
    {
        public Pizza CriarPizzaPepperoni()
        {
           return new PepperoniPizza();
        }

        public Pizza CriarPizzaQueijo()
        {
            return new CheesePizza();
        }
    }
}
