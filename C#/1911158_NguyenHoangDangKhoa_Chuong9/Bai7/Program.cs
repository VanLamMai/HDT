using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static List<Shirt> listShirt = new List<Shirt>();
        static void Main(string[] args)
        {
            CreatShirt();
            Console.WriteLine("List Shirt:");
            OutList();
            Console.ReadKey();
        }

        static void CreatShirt()
        {
            Shirt a = new Shirt("Cotton", "Red", "XL");
            listShirt.Add(a);
            Shirt b = new Shirt("Jean", "Blue", "L");
            listShirt.Add(b);
            Shirt c = new Shirt("Cotton", "White", "M");
            listShirt.Add(c);
            Shirt d = new Shirt("Polyester", "Cyan", "S");
            listShirt.Add(d);
            Shirt e = new Shirt("Paper", "Green", "L");
            listShirt.Add(e);
        }

        static void OutList()
        {
            foreach(var i in listShirt)
                Console.WriteLine(i);
        }
    }
}
