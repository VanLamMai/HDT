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
            string numString;
            int lastNum,
                threeDigit;

            Console.WriteLine("====================== CheckDigit ======================\n");
            Console.Write("Input Your Four-Digit Account Number: ");
            numString = Console.ReadLine();
            Console.WriteLine("\n========================================================\n");

            if (numString.Length != 4)
                Console.WriteLine("Your Four-Digit Account Number Is Ivalid!!! Stop Program!!!");
            else
            {
                threeDigit = int.Parse(numString.Substring(0, 3));
                lastNum = int.Parse(numString.Substring(3, 1));
                if (threeDigit % 7 == lastNum)
                    Console.WriteLine("{0} is valid.", numString);
                else
                    Console.WriteLine("{0} is invalid.", numString);
            }
            
            //Console.WriteLine(numString.Substring(0, 3)); 
            //Console.WriteLine(numString.Substring(3, 1));


            Console.ReadKey();
        }
    }
}
