using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            float txtscr1,
                txtscr2,
                txtscr3,
                txtscr4,
                txtscr5,
                txtscr6,
                txtscr7,
                txtscr8;
            float avg;
            Console.WriteLine("================== TestsInteractive  ==================\n");

            Console.Write("Input Test Score 1: ");
            txtscr1 = float.Parse(Console.ReadLine());
            Console.Write("\nInput Test Score 2: ");
            txtscr2 = float.Parse(Console.ReadLine());
            Console.Write("\nInput Test Score 3: ");
            txtscr3 = float.Parse(Console.ReadLine());
            Console.Write("\nInput Test Score 4: ");
            txtscr4 = float.Parse(Console.ReadLine());
            Console.Write("\nInput Test Score 5: ");
            txtscr5 = float.Parse(Console.ReadLine());
            Console.Write("\nInput Test Score 6: ");
            txtscr6 = float.Parse(Console.ReadLine());
            Console.Write("\nInput Test Score 7: ");
            txtscr7 = float.Parse(Console.ReadLine());
            Console.Write("\nInput Test Score 8: ");
            txtscr8 = float.Parse(Console.ReadLine());

            Console.WriteLine("\n=======================================================\n");

            avg = (txtscr1 + txtscr2 + txtscr3 + txtscr4 + txtscr5 + txtscr6 + txtscr7 + txtscr8) / 8;

            Console.WriteLine("Average of the test scores: " + Math.Round(avg,2));
            
            Console.ReadKey();
        }
    }
}
