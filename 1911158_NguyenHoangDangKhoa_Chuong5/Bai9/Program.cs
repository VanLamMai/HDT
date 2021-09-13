using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, 
                sum = 0,
                sumTemp = 0;
            Console.WriteLine("======================== Sum200 ========================\n");
            for (i = 1; i <= 200;i++)
            {
                sum += i;
                Console.Write("\t");
                Console.WriteLine(sumTemp + " + " + i + " = " + sum);
                sumTemp = sum;
                if (i == 100)
                {
                    Console.WriteLine("\nPress Any Key To Continue...");
                    Console.WriteLine("\n--------------------------------------------------------\n");
                    Console.ReadKey();
                }                  
            }
                Console.WriteLine("\n========================================================\n");
                Console.ReadKey();
        }
    }
}
