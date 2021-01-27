using System;

namespace Decorator
{
    public abstract class Pao
    {
        private String descricao;
        public abstract double Custo();

        public virtual String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
