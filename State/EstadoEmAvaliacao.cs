using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class EstadoEmAvaliacao: State
    {
        private Documento _doc;

        public EstadoEmAvaliacao(Documento doc)
        {
            this._doc = doc;
        }

        public void AceitarDocumento()
        {
            Console.WriteLine("O documento foi aceite!");
            this._doc.EstadoCorrente = this._doc.EstadoAceite;
        }

        public void RejeitarDocumento()
        {
            Console.WriteLine("O documento foi recusado!");
            this._doc.EstadoCorrente = this._doc.EstadoRecusado;
        }

        public void AvaliarDocumento()
        {
            Console.WriteLine("O documento já está a ser avaliado, por favor espera!");
        }

        public void Print()
        {
            Console.WriteLine("Estou no estado em avaliação!");
        }
    }
}
