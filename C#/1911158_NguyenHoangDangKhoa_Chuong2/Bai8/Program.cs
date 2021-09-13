using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            const double raisePercent = 4;
            double currSalaForOne;
            short amountEmployee = 3;
            double currSalaForThree;
            double salaRaise;
            double salaNextYear;

            Console.WriteLine("==================  ProjectedRaisesInteractive  ==================\n");
            Console.WriteLine("Raise percent: " + raisePercent + '%');
            Console.WriteLine("Amount employee: " + amountEmployee + '\n');
            Console.WriteLine("==================================================================\n");

            Console.Write("Input the current salaries for one employee: ");

            currSalaForOne = double.Parse(Console.ReadLine());
            currSalaForThree = currSalaForOne * amountEmployee;
            salaRaise = (currSalaForOne * raisePercent) / 100;
            
            Console.WriteLine();
            Console.WriteLine("==================================================================\n");
            Console.WriteLine("Current salaries for one employee: " + currSalaForOne);
            Console.WriteLine("Current salaries for " + amountEmployee + " employees: " + currSalaForThree + '\n');
            Console.WriteLine("==================================================================\n");
            salaNextYear = currSalaForOne + salaRaise;

            Console.WriteLine("Next year’s salary for each employee is {0}", salaNextYear);
            Console.ReadKey();
        }
    }
}
