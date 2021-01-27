using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class PaoBatata: Pao
    {
        public PaoBatata()
        {
            Descricao = "Pao de Batata";
        }

        public override double Custo()
        {
            return 1.2;
        }
    }
}
