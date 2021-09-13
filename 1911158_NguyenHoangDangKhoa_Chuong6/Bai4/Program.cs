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
            int i, check = 0;
            string[] zipCode;
            zipCode = new string[] {"AZ36e57", "EA58f47", "HF14t87", "LD49L79", "YJ87h25", 
                                     "GH45l87", "VB84n24", "ZX78s25", "WQ21p54", "SJ52a44"}; ;
            string codeUserBefore,
                   codeUserAfter;

            Console.WriteLine("========================= CheckZips =========================");

            do
            {
                Console.Write("\nEnter Your Zip Code (7 Digit, No Space): ");
                codeUserBefore = Console.ReadLine();
                if (codeUserBefore.Length != 7 || codeUserBefore.IndexOf(" ") != -1)
                    Console.WriteLine("{0} Is Invalid!!! Please Enter Again!!!", codeUserBefore);
            } while (codeUserBefore.Length != 7 || codeUserBefore.IndexOf(" ") != -1);  
            
            Console.WriteLine("\n-------------------------------------------------------------\n");

            codeUserAfter = codeUserBefore.ToLower();

            for (i = 0; i < zipCode.Length; i++)
            {
                if ((zipCode[i].ToLower()).CompareTo(codeUserAfter) == 0)
                {
                    Console.WriteLine("The zip code is in the company’s delivery area.");
                    check = 1;
                    break;
                }
                //Console.WriteLine(zipCode[i].ToLower());  
            }

            if (check == 0)
                Console.WriteLine("The zip code is not in the company’s delivery area.");

            Console.WriteLine("\n=============================================================\n");

            Console.ReadKey();
        }
    }
}
