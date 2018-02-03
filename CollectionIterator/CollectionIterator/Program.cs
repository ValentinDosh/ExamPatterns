using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers n = new Numbers();

            // добавим наблюдателей
            n.AddObserver(new ObserversNumbers("Андрюша"));
            n.AddObserver(new ObserversNumbers("Серёжа"));

            // наполним 
            n.AddItem(15);
            n.AddItem(4);
            n.AddItem(7);

            //
            foreach (var item in n)
            {
                Console.WriteLine(item);
            }

            n.RemoveItem(4);

            foreach (var item in n)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
