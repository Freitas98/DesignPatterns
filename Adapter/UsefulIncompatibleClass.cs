using System;

namespace Adapter
{
    public class UsefulIncompatibleClass
    {
        public void ComportamentoUtil1()
        {
            Console.WriteLine("Isto é um método útil mas é incompatível com a interface esperada pelo cliente.");
        }

        public void ComportamentoUtil2()
        {
            Console.WriteLine("Isto é outro método útil mas é incompatível com a interface esperada pelo cliente.");
        }
    }
}
