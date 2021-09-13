using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Job j1 = new Job("walking dog", 1, 10);
            Job j2 = new Job("painting a house", 10, 100);
            Job j3 = new Job("college faculty", 15, 50);

            Console.WriteLine(j1);
            Console.WriteLine();
            Console.WriteLine(j2);
            Console.WriteLine();
            Console.WriteLine(j3);
            Console.WriteLine();

            Console.WriteLine("OPERATOR + OVERLOADED TESTING ++++++++++++++++++++++++++++++++");
            Console.WriteLine(j1 + j2);
            Console.ReadKey();
        }
    }
}
