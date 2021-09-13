using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,
                num = 0;
            Console.WriteLine("============================ SumInts ============================\n");
            Console.WriteLine("Input 999 if you want to STOP PROGRAMING!!!");
            Console.WriteLine("\n-----------------------------------------------------------------");
            while (num != 999)
            {
                Console.Write("\nInput integer number: ");
                num = int.Parse(Console.ReadLine());
                if (num != 999)
                    sum += num;
            }
            Console.WriteLine("\n=================================================================\n");
            Console.WriteLine("Sum is: {0}", sum);
            Console.ReadKey();
        }
    }
}
