using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Animal
    {
        private String _name;

        public Animal(string name)
        {
            this._name = name;
        }

        public String Name
        {
            get
            {
                return this._name;
            }
        }
    }
}
