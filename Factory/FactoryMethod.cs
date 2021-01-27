using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class FactoryMethod
    {
        public void ImprimirPizza()
        {
            Pizza p = CriarPizza();

            Console.WriteLine(p.ToString());
        }

        protected abstract Pizza CriarPizza();
    }
}
