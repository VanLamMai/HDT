using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            string before, after;
            int indexSpace;
            const string w = "www.";
            const string com = ".com";

            Console.WriteLine("======================== WebAddress ========================\n");
            Console.Write(" Input Your Business Name: ");
            before = Console.ReadLine();
            Console.WriteLine("\n------------------------------------------------------------\n");

            after = before.Trim();
            for (int i = 0; i <= after.Length; i++)
            {
                indexSpace = after.IndexOf(' ');
                if (indexSpace != -1)
                    after = after.Remove(indexSpace, 1);         
            }

            //Console.WriteLine("Chuoi a la: {0}", a);

            Console.WriteLine(" A good Web address for '{0}' is:\n\n {1}{2}{3}",before, w, after, com);

            Console.WriteLine("\n============================================================\n");
            Console.ReadKey();
        }
    }
}
