using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Pasta: ItemSistemaOperativo
    {
        private List<ItemSistemaOperativo> _items;

        public Pasta(String name)
        {
            this.Nome = name;
            this._items = new List<ItemSistemaOperativo>();
            this.TemMudancas = false;
        }

        public override int ObterTamanho()
        {
            int tamanho = 0;
            foreach (var i in _items)
            {
                tamanho += i.ObterTamanho();
            }

            return tamanho;
        }

        public override bool Modificado()
        {
            foreach (var i in _items)
            {
                if (i.Modificado()) return true;
            }

            return false;
        }

        public override void Add(ItemSistemaOperativo i)
        {
            this._items.Add(i);
        }

        public override void Remove(ItemSistemaOperativo i)
        {
            if (!this._items.Contains(i)) return;
            this._items.Remove(i);
        }

        public override void Print()
        {
            String ficheiros = "";
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Modificado: " + this.Modificado());
            foreach (var i in this._items)
            {
                ficheiros += i.Nome + " | ";
            }
            Console.WriteLine("Items: " + ficheiros);
            Console.WriteLine("Tamanho: " + this.ObterTamanho());
            Console.WriteLine("\n");
        }
    }
}
