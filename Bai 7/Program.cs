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
            const double raisePercent = 4;
            double currSalaForOne = 7000000; 
            short amountEmployee = 3;
            double currSalaForThree = currSalaForOne * amountEmployee;
            double salaRaise = (currSalaForOne * raisePercent) / 100;
            double salaNextYear = currSalaForOne + salaRaise;

            Console.WriteLine("==================  ProjectedRaises  ==================\n");
            Console.WriteLine("Current salaries for one employee: " + currSalaForOne + '\n');
            Console.WriteLine("Current salaries for three employees: " + currSalaForThree + '\n');
            Console.WriteLine("Next year’s salary for each employee is {0}", salaNextYear);
            Console.ReadKey();

        }
    }
}
