using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlManager manager = new XmlManager(new UrlParser());
            manager.LoadUrls("test.txt", new FileManager());
            manager.WriteToXmlFile("xml.txt");
        }
    }
}
