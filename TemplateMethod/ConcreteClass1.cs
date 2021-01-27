using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ConcreteClass1: AbstractClass
    {
        protected override void Funcao2()
        {
            Console.WriteLine("Isto está implementado na subclasse ConcreteClass1: Função 2");
        }

    }
}
