using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string firstLetter,
                b;
            Console.WriteLine("================== PigLatin ==================\n");           
            Console.Write("Input Your String: ");
            a = Console.ReadLine();
            Console.WriteLine("\n==============================================\n");
            firstLetter = a.Substring(0, 1);
            b = a.Remove(0, 1);
            Console.WriteLine("{0} in Pig Latin is {1}{2}ay", a, b, firstLetter);
            Console.ReadKey();
        }
    }
}
