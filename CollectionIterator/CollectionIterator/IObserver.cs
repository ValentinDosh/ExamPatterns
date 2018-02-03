using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionIterator
{
    interface IObserver
    {
        void UpdateRemove(int x);
        void UpdateAdd(int x);
    }
}
