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
            double sum = 0,
                    count = 0,
                    avg;
            double temp = 0;

            Console.WriteLine("======================== DailyTemps ========================\n");
            Console.WriteLine("Input 999 if you want to STOP PROGRAMING!!!");
            for (int i = 1; temp != 999;i++ )
            {
                Console.WriteLine("\n------------------------------------------------------------\n");
                Console.Write("Input temperatures day {0}: ", i);
                temp = double.Parse(Console.ReadLine());

                if (temp != 999 && (temp >= -20 && temp <= 130))
                {
                    sum += temp;
                    count++;
                }                  
                else if (temp != 999 && (temp < -20 || temp > 130))
                    Console.WriteLine("Error!!! Please Input again!!!");
                else
                    break;
            }

            avg = sum / count;

            Console.WriteLine("\nYou entered {0} number of temperatures.", count);
            Console.WriteLine("\nThe average temperature is: {0} Fahrenheit", Math.Round(avg, 2)); 
            Console.WriteLine("\n============================================================\n");
            Console.ReadKey();
        }
    }
}
