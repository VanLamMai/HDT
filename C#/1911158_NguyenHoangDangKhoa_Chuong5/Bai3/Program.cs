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
            char upperLetter;

            Console.WriteLine("======================== EnterUppercaseLetters ========================\n");
            do
            {
                Console.Write("\nType an uppercase letter from the keyboard: ");
                upperLetter = char.Parse(Console.ReadLine());
                if ((int)upperLetter < 65 || (int)upperLetter > 90)
                {
                    Console.WriteLine("\nError!!! Please type again");
                    Console.WriteLine("\n-----------------------------------------------------------------------");
                }                    
            } while ((int)upperLetter < 65 || (int)upperLetter > 90);           
            Console.WriteLine("\n=======================================================================\n");
            Console.WriteLine("OK");
            Console.ReadKey();

        }
    }
}
