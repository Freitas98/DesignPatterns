using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Luz
    {
        private bool _acesa;

        public bool Acesa
        {
            get { return _acesa; }
        }

        public Luz()
        {
            this._acesa = false;
        }

        public void LigarLuz()
        {
            this._acesa = true;
        }

        public void DesligarLuz()
        {
            this._acesa = false;
        }
    }
}
