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
            double avg,
                admission;

            Console.WriteLine("====================== Admission ======================\n");
            Console.Write("Input Your High School Grade Point Average: ");
            avg = double.Parse(Console.ReadLine());
            Console.Write("\nInput Your Admission Test Score: ");
            admission = double.Parse(Console.ReadLine());
            Console.WriteLine("\n=======================================================\n");

            if (avg >= 3.0 && admission >= 60 || avg < 3.0 && admission >= 80)
                Console.WriteLine("Accept!!!");
            else
                Console.WriteLine("Reject!!!");

            Console.ReadKey();
        }
    }
}
