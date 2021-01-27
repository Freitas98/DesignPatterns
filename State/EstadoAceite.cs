using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class EstadoAceite: State
    {
        private Documento _doc;

        public EstadoAceite(Documento doc)
        {
            this._doc = doc;
        }

        public void AceitarDocumento()
        {
            Console.WriteLine("O documento já se encontra aceite!");
        }

        public void RejeitarDocumento()
        {
            Console.WriteLine("Um documento aceite não pode ser rejeitado!");
        }

        public void AvaliarDocumento()
        {
            Console.WriteLine("O documento foi colocado em avaliação!");
            this._doc.EstadoCorrente = this._doc.EstadoEmAvaliacao;
        }

        public void Print()
        {
            Console.WriteLine("Estou no estado aceite!");
        }
    }
}
