using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Alface: PaoDecorator
    {
        private Pao pao;

        public Alface(Pao aPao)
        {
            this.pao = aPao;
        }

        public override double Custo()
        {
            return this.pao.Custo() + 0.4;
        }

        public override string Descricao
        {
            get { return pao.Descricao + ", Alface"; }
        }
    }
}
