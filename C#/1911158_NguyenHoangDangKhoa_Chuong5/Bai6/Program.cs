using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, multi;
            Console.WriteLine("======================== DisplayMultiplicationTable ========================\n");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n----------------------------------------------------------------------------\n");
                for (j = 1; j <= 10; j++)
                {
                    multi = i * j;
                    Console.WriteLine(i + " x " + j + " = " + multi);
                }
            }           
            Console.WriteLine("\n============================================================================\n");
            Console.ReadKey();
        }
    }
}
