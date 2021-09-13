using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, check = 0;
            string[] zipCode;
            zipCode = new string[] {"AZ36e57", "EA58f47", "HF14t87", "LD49L79", "YJ87h25", 
                                     "GH45l87", "VB84n24", "ZX78s25", "WQ21p54", "SJ52a44"};
            int[] priceDelivery;
            priceDelivery = new int[] {30, 50, 25, 40, 100, 
                                       15, 28, 46, 75, 56};

            string codeUserBefore,
                   codeUserAfter;

            Console.WriteLine("========================= DeliveryCharges =========================");        

            do
            {
                Console.Write("\nEnter Your Zip Code (7 Digit, No Space): ");
                codeUserBefore = Console.ReadLine();
                if (codeUserBefore.Length != 7 || codeUserBefore.IndexOf(" ") != -1)
                    Console.WriteLine("{0} Is Invalid!!! Please Enter Again!!!", codeUserBefore);
            } while (codeUserBefore.Length != 7 || codeUserBefore.IndexOf(" ") != -1);

            Console.WriteLine("-------------------------------------------------------------------\n");

            codeUserAfter = codeUserBefore.ToLower();

            for (i = 0; i < zipCode.Length; i++)
            {
                if ((zipCode[i].ToLower()).CompareTo(codeUserAfter) == 0)
                {
                    Console.WriteLine("The price of delivery to {0} is: ${1}", zipCode[i], priceDelivery[i]);
                    check = 1;
                    break;
                }
                //Console.WriteLine(zipCode[i].ToLower());  
            }

            if (check == 0)
                Console.WriteLine("The zip code is not in the company’s delivery area.");

            Console.WriteLine("\n===================================================================\n");

            Console.ReadKey();          
        }
    }
}
