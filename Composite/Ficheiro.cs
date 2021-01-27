using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Composite
{
    public class Ficheiro: ItemSistemaOperativo
    {
        public Ficheiro(String name)
        {
            this.Nome = name;
            this.Tamanho = new Random().Next(1, 65);
            this.TemMudancas = false;
        }

        public override int ObterTamanho()
        {
            return this.Tamanho;
        }

        public override bool Modificado()
        {
            return this.TemMudancas;
        }

        public override void AlterarFicheiro()
        {
            this.TemMudancas = true;
        }

        public override void Print()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Modificado: " + this.Modificado());
            Console.WriteLine("Tamanho: " + this.ObterTamanho());
            Console.WriteLine("\n");
        }
    }
}
