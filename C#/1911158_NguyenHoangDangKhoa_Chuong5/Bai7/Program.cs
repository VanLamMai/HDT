using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            int i, j, multi;
            do
            {
                Console.Clear();
                Console.WriteLine("======================== MultiplicationTable ========================\n");
                Console.Write("Input integer number: ");
                num = double.Parse(Console.ReadLine());
                if (num - (int)num != 0)
                {
                    Console.WriteLine("\n{0} is invalid!!! Please input again!!!", num);
                    Console.ReadKey();
                }
            } while (num - (int)num != 0);

            Console.WriteLine("\n---------------------------------------------------------------------\n");

            for (i = 1; i <= 10; i++)
            {
                Console.Write('\t');
                multi = i * (int)num;
                Console.WriteLine(num + " x " + i + " = " + multi);
            }
            
            Console.WriteLine("\n=====================================================================\n");
            Console.ReadKey();
        }
    }
}
