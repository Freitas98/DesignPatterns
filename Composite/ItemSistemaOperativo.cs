using System;

namespace Composite
{
    public abstract class ItemSistemaOperativo
    {
        private String _nome;
        private int _tamanho;
        private bool _temMudancas;

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Tamanho
        {
            get { return _tamanho; }
            set { _tamanho = value; }
        }

        public bool TemMudancas
        {
            get { return _temMudancas; }
            set { _temMudancas = value; }
        }

        public virtual void Add(ItemSistemaOperativo i)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(ItemSistemaOperativo i)
        {
            throw new NotImplementedException();
        }

        public virtual int ObterTamanho()
        {
            throw new NotImplementedException();
        }

        public virtual bool Modificado()
        {
            throw new NotImplementedException();
        }

        public virtual void AlterarFicheiro()
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }

    }
}
