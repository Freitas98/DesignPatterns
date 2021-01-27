using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class EstadoRecusado: State
    {
        private Documento _doc;

        public EstadoRecusado(Documento doc)
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
            Console.WriteLine("O documento já se encontra rejeitado!");

        }

        public void AvaliarDocumento()
        {
            Console.WriteLine("O documento foi colocado em avaliação!");
            this._doc.EstadoCorrente = this._doc.EstadoEmAvaliacao;
        }

        public void Print()
        {
            Console.WriteLine("Estou no estado Recusado!");
        }
    }
}
