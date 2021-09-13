using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesTransaction s1 = new SalesTransaction("Nam", 15, 2.5);
            SalesTransaction s2 = new SalesTransaction("Hoa", 10);
            SalesTransaction s3 = new SalesTransaction("Tung");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
