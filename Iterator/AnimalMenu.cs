using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class AnimalMenu
    {
        private Animal[] _animals;

        public AnimalMenu(Animal[] animals)
        {
            this._animals = animals;
        }

        public Iterator GetIterator()
        {
            return new AnimalIterator(this._animals);
        }
    }
}
