using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CompositeWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            // загружаем наши файлы в память
            XmlDocument main = new XmlDocument();
            main.Load("1.html");
            XmlDocument africanInsects = new XmlDocument();
            africanInsects.Load("2.html");
            XmlDocument europeanInsects = new XmlDocument();
            europeanInsects.Load("3.html");
            XmlDocument mosquito = new XmlDocument();
            mosquito.Load("4.html");
            XmlDocument ladyBug = new XmlDocument();
            ladyBug.Load("5.html");

            //строим нашу иерархия 
            var _ladyBug = new Element(ladyBug, "ГЛУБИНА - 3");
            var _mosquito = new Element(mosquito, "ГЛУБИНА - 3");

            var _europeanInsects = new Composite(europeanInsects, "ГЛУБИНА - 2");
            var _africanInsects = new Composite(africanInsects, "ГЛУБИНА - 2");

            var _main = new Composite(main, "ГЛУБИНА - 1");


            _europeanInsects.Add(_ladyBug);
            _africanInsects.Add(_mosquito);
            _main.Add(_europeanInsects);
            _main.Add(_africanInsects);

            // выводим все деоево страниц
            _main.Display();
            Console.ReadLine();
        }
    }
}
