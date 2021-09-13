using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    class Program
    {
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            int num;
            Months changeNum;
            Console.WriteLine("================== MonthNames ==================\n");           
            Console.Write("Input Month Number: ");
            num = int.Parse(Console.ReadLine());
            changeNum = (Months)num;
            Console.WriteLine("\n================================================\n");
            Console.WriteLine("{0} is {1}", num, changeNum);
            Console.ReadKey();
        }
    }
}
