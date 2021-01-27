using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Cliente
    {
        private IAlgoritmoEstrategia _estrategiaUsar;

        public Cliente(IAlgoritmoEstrategia estrategiaUsar)
        {
            this._estrategiaUsar = estrategiaUsar;
        }

        public IAlgoritmoEstrategia EstrategiaUsar
        {
            set
            {
                Console.WriteLine("Alterei a minha estratégia!\n");
                this._estrategiaUsar = value;
            }
        }

        public void FuncaoDoCliente()
        {
            Console.WriteLine("Isto é uma função do cliente e o comportamento é dinâmico consoante a estratégia escolhida.\n");
            _estrategiaUsar.Estrategia();
        }

    }
}
