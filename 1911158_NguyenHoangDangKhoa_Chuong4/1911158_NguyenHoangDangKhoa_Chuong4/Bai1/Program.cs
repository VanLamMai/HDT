using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            Console.WriteLine("====================== CheckCredit ======================\n");
            Console.Write("Input your price: ");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("\n=========================================================\n");
            if (price > 8000)
                Console.WriteLine("Your price is ${0}, is greater than a credit limit of $8,000", price);
            else
                Console.WriteLine("Approved");
            Console.ReadKey();

        }
    }
}
