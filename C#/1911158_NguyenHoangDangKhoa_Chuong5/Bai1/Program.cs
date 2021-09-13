using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,
                num;
            Console.WriteLine("============================ SumFiveInts ============================");            
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("\nInput integer number {0}: ",i);
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("\n=====================================================================\n");
            Console.WriteLine("Sum is: {0}", sum);
            Console.ReadKey();
        }
    }
}
