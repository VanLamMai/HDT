using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            char[] grade;
            grade = new char[] {'A', 'B', 'C', 'D', 'F'};

            Console.WriteLine("========================= TypingGrades =========================");
            do
            {
                Console.Write("\nEnter number of words typed: ");
                num = double.Parse(Console.ReadLine());
                if ((num - (int)num != 0) || num < 0)
                    Console.WriteLine("{0} Is Invalid!!! Plaease Enter Again!!!", num);
            } while ((num - (int)num != 0) || num < 0);

            Console.WriteLine("\n----------------------------------------------------------------\n");

            if (num >= 0 && num <= 15)
                Console.WriteLine("Grade: {0}", grade[4]);
            else if (num >= 16 && num <= 30)
                Console.WriteLine("Grade: {0}", grade[3]);
            else if (num >= 31 && num <= 50)
                Console.WriteLine("Grade: {0}", grade[2]);
            else if (num >= 51 && num <= 75)
                Console.WriteLine("Grade: {0}", grade[1]);
            else 
                Console.WriteLine("Grade: {0}", grade[0]);

            Console.WriteLine("\n================================================================\n");
            Console.ReadKey();
        }
    }
}
