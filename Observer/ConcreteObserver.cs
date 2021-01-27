using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ConcreteObserver: IObserver
    {
        private String _name;

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public void update(string name)
        {
            this._name = name;
            Console.WriteLine("Observer: O nome do documento foi alterado para: " + name);
        }
    }
}
