using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CompositeWeb
{
    abstract class Component
    {
        protected string _name;
        protected XmlDocument _doc;

        protected Component(XmlDocument doc, string name)
        {
            _name = name;
            _doc = doc;
        }

        public virtual void Add(Component componnt) { }
        public virtual void Remove(Component componnt) { }
        public virtual void Display() { }
    }
}
