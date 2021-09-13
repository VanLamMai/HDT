using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;
            Console.WriteLine("====================== Twitter ======================\n");
            Console.WriteLine("Write Your Message Here: ");
            mes = Console.ReadLine();
            Console.WriteLine("\n=====================================================\n");

            if (mes.Length > 140)
                Console.WriteLine("Your message is more than 140 characters!!!");
            else
                Console.WriteLine("Your message have been sent!");

            Console.ReadKey();
        }
    }
}
