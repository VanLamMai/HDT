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
            int month,
                month2,
                day2;
            Console.WriteLine("====================== CheckMonth ======================\n");
            Console.Write("Input Your Birth Month: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------------\n");

            if (month < 1 || month > 12)
                Console.WriteLine("Your month is invalid!!!");
            else
                Console.WriteLine("{0} is a valid month.", month);


            Console.WriteLine("\n====================== CheckMonth2 =====================\n");
            Console.Write("Input Your Birth Day: ");
            day2 = int.Parse(Console.ReadLine());
            Console.Write("Input Your Birth Month: ");
            month2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------------\n");

            if (month2 < 1 || month2 > 12)
                Console.WriteLine("Your month is invalid!!!");
            else if (month2 == 1 || month2 == 3 || month2 == 5 || month2 == 7 || month2 == 8 || month2 == 10 || month2 == 12) 
            {
                if (1<= day2 && day2 <=31)
                     Console.WriteLine("{0} is a valid day and {1} is a valid month.", day2, month2);
                else
                     Console.WriteLine("{0} is a invalid day!!!", day2);
            }
            else if (month2 == 2)
            {
                if (1 <= day2 && day2 <= 29)
                    Console.WriteLine("{0} is a valid day and {1} is a valid month.", day2, month2);
                else
                    Console.WriteLine("{0} is a invalid day in month {1}!!!", day2, month2);
            }
            else
            {
                if (1 <= day2 && day2 <= 30)
                    Console.WriteLine("{0} is a valid day and {1} is a valid month.", day2, month2);
                else
                    Console.WriteLine("{0} is a invalid day in month {1}!!!", day2, month2);
            }

            Console.ReadKey();

        }
    }
}
