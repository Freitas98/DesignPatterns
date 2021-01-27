using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class PaoQueijo: Pao
    {
        public PaoQueijo()
        {
            Descricao = "Pao de Queijo";
        }

        public override double Custo()
        {
            return 1.8;
        }
    }
}
