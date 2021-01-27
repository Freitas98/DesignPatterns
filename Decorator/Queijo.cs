using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Queijo: PaoDecorator
    {
        private Pao pao;

        public Queijo(Pao aPao)
        {
            this.pao = aPao;
        }

        public override double Custo()
        {
            return this.pao.Custo() + 0.15;
        }

        public override string Descricao
        {
            get { return pao.Descricao + ", Queijo"; }
        }
    }
}
