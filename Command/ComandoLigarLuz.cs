using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class ComandoLigarLuz: ICommand
    {
        private Luz _luz;

        public ComandoLigarLuz(Luz luz)
        {
            this._luz = luz;
        }

        public void Execute()
        {
            this._luz.LigarLuz();
        }

        public void Undo()
        {
            this._luz.DesligarLuz();
        }

        public void Redo()
        {
            this._luz.LigarLuz();
        }
    }
}
