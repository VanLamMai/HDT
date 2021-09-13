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
            int i, checkPerfect;
            Console.WriteLine("======================== Perfect ========================\n");
            Console.WriteLine("Perfect numbers is:\n");
            for (i = 1; i <= 10000; i++)
            {
                checkPerfect = CheckNumberPerfect(i);
                if (checkPerfect == 1)
                    Console.Write("\t" + i);
            }
            Console.WriteLine("\n\n=========================================================\n");
            Console.ReadKey();
        }

        static int CheckNumberPerfect(int a)
        {
            int i, sum = 0;
            for (i = 1; i <= a/2; i++)
            {
                if (a % i == 0)
                    sum += i;
            }
            if (sum == a)
                return 1;
            else
                return 0;
        }
    }
}
