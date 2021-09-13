using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            int egg,
               eggChick1,
               eggChick2,
               eggChick3,
               eggChick4;
            int totalEgg, dozen;

            Console.WriteLine("==================  EggsInteractive    ==================\n");
            Console.Write("Amount Eggs Of Chicken 1: ");
            eggChick1 = int.Parse(Console.ReadLine());
            Console.Write("\nAmount Eggs Of Chicken 2: ");
            eggChick2 = int.Parse(Console.ReadLine());
            Console.Write("\nAmount Eggs Of Chicken 3: ");
            eggChick3 = int.Parse(Console.ReadLine());
            Console.Write("\nAmount Eggs Of Chicken 4: ");
            eggChick4 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n=========================================================\n");

            totalEgg = eggChick1 + eggChick2 + eggChick3 + eggChick4;
            Console.WriteLine("Total eggs in a month: {0} eggs", totalEgg);
            Console.WriteLine("\n=========================================================\n");

            dozen = totalEgg / 12;
            egg = totalEgg % 12;
            Console.WriteLine("Total of {0} eggs is {1} dozen and {2} eggs", totalEgg, dozen, egg);

            Console.ReadKey();
        }
    }
}
