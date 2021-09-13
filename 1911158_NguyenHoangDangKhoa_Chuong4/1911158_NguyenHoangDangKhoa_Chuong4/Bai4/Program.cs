using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            double windSpeed;

            Console.WriteLine("====================== Hurricane ======================\n");
            Console.Write("Input Wind Speed: ");
            windSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine("\n=======================================================\n");

            if (windSpeed >= 74 && windSpeed < 96)
                Console.WriteLine("Hurricane number 1!!!");
            else if (windSpeed >= 96 && windSpeed < 111)
                Console.WriteLine("Hurricane number 2!!!");
            else if (windSpeed >= 111 && windSpeed < 130)
                Console.WriteLine("Hurricane number 3!!!");
            else if (windSpeed >= 130 && windSpeed < 157)
                Console.WriteLine("Hurricane number 4!!!");
            else if (windSpeed >= 157)
                Console.WriteLine("Hurricane number 5!!!");
            else
                Console.WriteLine("Not Hurricane.");

            Console.ReadKey();
        }
    }
}
