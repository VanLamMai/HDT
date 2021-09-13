using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areaCode;
            double[] perMinute;

            areaCode = new int[] { 262, 414, 608, 715, 815, 920 };
            perMinute = new double[] { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            int areaCodeUser,
                check = 0;
            double minuteLenght,
                   total;

            Console.WriteLine("========================= ChatAWhile =========================");

            do
            {
                Console.Write("\nEnter The Area Code: ");
                areaCodeUser = int.Parse(Console.ReadLine());
                if (areaCodeUser <= 0)
                    Console.WriteLine("{0} Is Invalid!!! Plaease Enter Again!!!", areaCodeUser);
            } while (areaCodeUser <= 0);

            for (int i = 0; i < areaCode.Length; i++)
            {
                if (areaCodeUser == areaCode[i])
                {
                    do
                    {
                        Console.Write("\nEnter The Length Of Time For A Call In Minutes: ");
                        minuteLenght = double.Parse(Console.ReadLine());
                        if (minuteLenght < 0)
                            Console.WriteLine("{0} Is Invalid!!! Plaease Enter Again!!!", minuteLenght);
                    } while (minuteLenght <= 0);
                    Console.WriteLine("Per-Minute Rate Is: ${0}", perMinute[i]);
                    total = minuteLenght * perMinute[i];
                    Console.WriteLine("\n--------------------------------------------------------------\n");
                    Console.WriteLine("Total cost of the call is: ${0}", total);
                    check = 1;
                    break;
                }                   
            }
          
            if (check == 0)
            {
                Console.WriteLine("\n--------------------------------------------------------------\n");
                Console.WriteLine("{0} is not in the area code!!!", areaCodeUser);
            }                

            Console.WriteLine("\n==============================================================\n");
            Console.ReadKey();
        }
    }
}
