using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Estrategia1: IAlgoritmoEstrategia
    {
        public void Estrategia()
        {
            Console.WriteLine("Estou a usar a estratégia 1!\n");
        }
    }
}
