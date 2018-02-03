using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CompositeWeb
{
    class Composite : Component
    {
        private List<Component> _elements = new List<Component>();

        public Composite(XmlDocument doc, string name) : base(doc, name)
        {
        }

        public override void Add(Component componnt)
        {
            _elements.Add(componnt);
        }

        public override void Remove(Component componnt)
        {
            _elements.Remove(componnt);
        }

        public override void Display()
        {
            // вывели уровень глубины
            Console.WriteLine(_name);

            // вывели нашу страницу, рспарсили
            XmlElement xRoot = _doc.DocumentElement;

            foreach (XmlNode item1 in xRoot)
            {
                if (item1.Name == "body")
                {
                    foreach (XmlNode item3 in item1.ChildNodes)
                    {

                        if (item3.Name == "h1" || item3.Name == "h2" || item3.Name == "h3" || item3.Name == "h4")
                        {
                            Console.WriteLine("\t\t\t{0}\n\n", item3.InnerText);
                        }

                        if (item3.Name == "p")
                        {
                            Console.WriteLine("\t{0}\n", item3.InnerText);
                        }
                    }
                }


            }

            // выводим вложеные страницы
            foreach (var item in _elements)
            {
                item.Display();
            }
        }
    }
}
