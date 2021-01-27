using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ConcreteClass2: AbstractClass
    {
        protected override void Funcao2()
        {
            Console.WriteLine("Isto está implementado na subclasse ConcreteClass2: Função 2");
        }

        protected override void Hook()
        {
            Console.WriteLine("Eu sou um Hook definido na subclass ConcreteClass2!");
        }
    }
}
