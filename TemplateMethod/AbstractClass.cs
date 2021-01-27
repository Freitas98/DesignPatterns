using System;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Funcao1();
            Funcao2();
            Funcao3();
            Hook();
        }

        private void Funcao1()
        {
            Console.WriteLine("Isto está implementado na superclass: Função 1");
        }

        private void Funcao3()
        {
            Console.WriteLine("Isto está implementado na superclass: Função 3");
        }
        protected virtual void Hook(){}

        protected abstract void Funcao2();
    }
}
