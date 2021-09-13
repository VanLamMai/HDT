using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,
                n = 6;
            double[] tempe;
            double sum = 0, 
                   avg;
            tempe = new double[n];
            Console.WriteLine("======================= TemperaturesComparison =======================");

            for (i = 1; i < tempe.Length; i++)
            {
                do
                {
                    Console.Write("\nEnter temperature day {0}: ", i);
                    tempe[i] = double.Parse(Console.ReadLine());
                    if (tempe[i] < -30 || tempe[i] > 130)
                        Console.WriteLine("{0} is invalid!!! Please Enter Again!!!", tempe[i]);
                } while (tempe[i] < -30 || tempe[i] > 130);
            }

            Console.WriteLine("\n----------------------------------------------------------------------\n");

            if (CheckGrow(tempe))
                Console.WriteLine("Getting Warmer");
            else if (CheckDes(tempe))
                Console.WriteLine("Getting Cooler");
            else
                Console.WriteLine("It’s a mixed bag");

            Console.WriteLine("\n----------------------------------------------------------------------\n");

            for (i = 1; i < tempe.Length; i++)
            {
                Console.WriteLine("Temperature Day #{0} Is: {1}", i, tempe[i]);
                sum += tempe[i];
            }

            avg = sum / (n - 1);

            Console.WriteLine("\n----------------------------------------------------------------------\n");

            Console.WriteLine("The average of the temperatures is: {0}", avg);

            Console.WriteLine("\n======================================================================\n");
            Console.ReadKey();
        }

        static bool CheckGrow(double[] tempe)
        {
            int i;
            for (i = 1; i < tempe.Length - 1; i++)
            {
                if (tempe[i] > tempe[i + 1])
                    return false;               
            }
            return true;
        }

        static bool CheckDes(double[] tempe)
        {
            int i;
            for (i = 1; i < tempe.Length - 1; i++)
            {
                if (tempe[i] < tempe[i + 1])
                    return false;
            }
            return true;
        }
    }
}
