using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter: IClientInterface
    {
        private UsefulIncompatibleClass _usefulIncompatibleClass;

        public Adapter(UsefulIncompatibleClass aUsefulIncompatibleClass)
        {
            this._usefulIncompatibleClass = aUsefulIncompatibleClass;
        }

        public void MetodoUsadoCliente1()
        {
            this._usefulIncompatibleClass.ComportamentoUtil1();
        }

        public void MetodoUsadoCliente2()
        {
            this._usefulIncompatibleClass.ComportamentoUtil2();
        }
    }
}
