using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionIterator
{
    class Numbers : IEnumerable<int>, IObservable
    {
        private List<int> _items = new List<int>();

        // наблюдатели
        private List<IObserver> _observers = new List<IObserver>();

        public void AddItem(int item)
        {
            _items.Add(item);
            _items.Sort();
            NotifyObserversAdd(item);
        }

        public void RemoveItem(int item)
        {
            _items.Remove(item);
            _items.Sort();
            NotifyObserversRemove(item);
        }

        public int GetItem(int index)
        {
            return _items[index];
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _items)
            {
                // "генератор" значений, реализующий отложенные вычисления
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //////////////////////////////////////////////////////////////////

        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Add(o);
        }


        public void NotifyObserversRemove(int x)
        {
            foreach (var item in _observers)
            {
                item.UpdateRemove(x);
            };
        }

        public void NotifyObserversAdd(int x)
        {
            foreach (var item in _observers)
            {
                item.UpdateAdd(x);
            };
        }
    }
}
