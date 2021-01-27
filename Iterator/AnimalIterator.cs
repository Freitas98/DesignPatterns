using System;

namespace Iterator
{
    public class AnimalIterator: Iterator
    {
        private Animal[] _animals;
        private int _position;

        public AnimalIterator(Animal[] animals)
        {
            this._animals = animals;
            _position = 0;
        }
        public bool HasNext()
        {
            if (_position > _animals.Length - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            Animal a = _animals[this._position];
            this._position++;
            return a;
        }

        public void Reset()
        {
            this._position = 0;
        }
    }
}
