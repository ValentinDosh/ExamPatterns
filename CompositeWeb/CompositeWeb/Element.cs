using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CompositeWeb
{
    class Element : Component
    {
        public Element(XmlDocument doc, string name) : base(doc, name) { }

        public override void Display()
        {
            Console.WriteLine(_name);




            // вывод файла html на консоль
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
        }

    }
}
