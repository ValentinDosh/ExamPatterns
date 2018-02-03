using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionIterator
{
    class ObserversNumbers : IObserver
    {
        public string Name { get; set; }

        public ObserversNumbers(string name)
        {
            Name = name;
        }

        public void UpdateAdd(int x)
        {
            Console.WriteLine("Наблюдатель {0}", Name);
            Console.WriteLine("Был добавлен элемент: целое число - {0}", x);
        }

        public void UpdateRemove(int x)
        {
            Console.WriteLine("Наблюдатель {0}", Name);
            Console.WriteLine("Был удылен элемент: целое число - {0}", x);
        }
    }
}
