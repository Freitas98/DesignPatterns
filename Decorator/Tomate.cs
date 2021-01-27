using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Tomate: PaoDecorator
    {
        private Pao pao;

        public Tomate(Pao aPao)
        {
            this.pao = aPao;
        }

        public override double Custo()
        {
            return this.pao.Custo() + 0.25;
        }

        public override string Descricao
        {
            get { return pao.Descricao + ", Tomate"; }
        }
    }
}
