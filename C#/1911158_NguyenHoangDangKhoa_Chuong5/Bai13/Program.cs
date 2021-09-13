using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            string before, after;
            int count = 0, indexSpace;

            Console.WriteLine("======================== HomeSales ========================\n");

            Console.Write("Input Your String: ");
            before = Console.ReadLine();           
            Console.WriteLine("\n---------------------------------------------------------\n");

            after = before.Trim();
            after = after.ToLower();

            for (int i = 0; i <= after.Length; i++)
            {
                indexSpace = after.IndexOf(' ');
                if (indexSpace != -1)
                    after = after.Remove(indexSpace, 1);
            }

            for (int i = 0; i < after.Length; i++)
            {
                if ((char)after[i] == 'a' || (char)after[i] == 'e' || (char)after[i] == 'i' || (char)after[i] == 'o' || (char)after[i] == 'u')
                    count++;
            }

            Console.WriteLine("Vowels: {0}", count);

            //for (int i = 0; i < after.Length; i++)
            //{
            //    Console.WriteLine((char)after[i]);
            //}

            Console.WriteLine("\n===========================================================\n");
            Console.ReadKey();
        }
    }
}
