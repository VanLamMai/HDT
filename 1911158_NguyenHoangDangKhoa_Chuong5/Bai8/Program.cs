using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, 
                oddNum = 0;
            Console.WriteLine("======================== OddNums ========================");
            for (i = 0; oddNum <= 98; i++)
            {
                oddNum = 2 * i + 1;
                if ((oddNum - 1) % 10 == 0)
                    Console.Write("\n\t");
                else
                    Console.Write('\t');
                Console.Write(oddNum);               
            }
            Console.WriteLine("\n\n=========================================================\n");
            Console.ReadKey();
        }
    }
}
