using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            int beforeDollar,
                dollar,
                twenties,
                ten,
                fives,
                ones;

            Console.WriteLine("================== MakeChange ==================\n");
            Console.Write("Input dollars: ");
            beforeDollar = int.Parse(Console.ReadLine());
            Console.WriteLine("\n================================================\n");

            dollar = beforeDollar;
            twenties = dollar / 20;
            dollar = dollar % 20;
            ten = dollar / 10;
            dollar = dollar % 10;
            fives = dollar / 5;
            dollar = dollar % 5;
            ones = dollar / 1;

            Console.WriteLine("${0} is {1} twenties, {2} ten, {3} fives, and {4} ones", beforeDollar, twenties, ten, fives, ones);
            Console.ReadKey();
        }
    }
}
