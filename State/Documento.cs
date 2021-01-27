using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Documento
    {
        private State _estadoAceite;
        private State _estadoRecusado;
        private State _estadoEmAvaliacao;
        private State _estadoCorrente;

        public Documento()
        {
            this._estadoAceite = new EstadoAceite(this);
            this._estadoRecusado = new EstadoRecusado(this);
            this._estadoEmAvaliacao = new EstadoEmAvaliacao(this);
            this._estadoCorrente = this._estadoEmAvaliacao;
        }

        public State EstadoAceite
        {
            get { return _estadoAceite; }
        }

        public State EstadoRecusado
        {
            get { return _estadoRecusado; }
        }

        public State EstadoEmAvaliacao
        {
            get { return _estadoEmAvaliacao; }
        }

        public State EstadoCorrente
        {
            get { return _estadoCorrente; }
            set { this._estadoCorrente = value; }
        }

        public void AvaliarDocumento()
        {
            this._estadoCorrente.AvaliarDocumento();
        }

        public void RejeitarDocumento()
        {
            this._estadoCorrente.RejeitarDocumento();
        }

        public void AceitarDocumento()
        {
            this._estadoCorrente.AceitarDocumento();
        }

        public void VerificarEstado()
        {
            this._estadoCorrente.Print();
        }
    }
}
