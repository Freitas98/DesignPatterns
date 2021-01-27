using System;
using System.Collections.Generic;

namespace Observer
{
    public class Document: ISubject
    {
        private String _name;
        private List<IObserver> _observers;

        public Document(string name)
        {
            this._name = name;
            this._observers = new List<IObserver>();
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void AddObserver(IObserver o)
        {
            this._observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (!this._observers.Contains(o)) return;
            this._observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var o in this._observers)
            {
                o.update(this._name);
            }
        }

        public void AlterarNomeDocumento(string name)
        {
            this._name = name;
            NotifyObservers();
        }
    }
}
