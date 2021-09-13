using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            double fah,
                cel;
            Console.WriteLine("================== FahrenheitToCelsius ==================\n");
            Console.Write("Input Fahrenheit: ");
            fah = double.Parse(Console.ReadLine());
            Console.WriteLine("\n=========================================================\n");

            cel = (fah - 32) * 5 / 9;

            Console.WriteLine("{0} Fahrenheit is {1} Celsius", Math.Round(fah, 1), Math.Round(cel, 1));

            Console.ReadKey();
        }
    }
}
