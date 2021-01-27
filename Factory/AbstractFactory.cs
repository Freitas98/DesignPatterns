using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface AbstractFactory
    {
        Pizza CriarPizzaPepperoni();
        Pizza CriarPizzaQueijo();
    }
}
