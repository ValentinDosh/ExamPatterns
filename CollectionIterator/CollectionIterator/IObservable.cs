using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionIterator
{
    interface IObservable
    {
        void RemoveObserver(IObserver o);
        void AddObserver(IObserver o);
        void NotifyObserversRemove(int x);
        void NotifyObserversAdd(int x);
    }
}
