using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace XMLDocument
{
    public class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Teg.xml");
            var root = document.DocumentElement;
            foreach (XmlNode child in root.ChildNodes)
            {
                Console.WriteLine("{0}   ", child.LocalName);
            }
            Console.ReadLine();

        }
    }
}
