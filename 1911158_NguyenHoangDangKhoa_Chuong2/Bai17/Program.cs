using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    class Program
    {
        enum Planets
        {
            Mercury = 1,
            Venus,
            Earth,
            Mars,
            Jupiter,
            Saturn,
            Uranus,
            Neptune
        }

        static void Main(string[] args)
        {
            int num;
            Planets changeNum;

            Console.WriteLine("================== Planets ==================\n");            
            Console.Write("Input numeric position: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n=============================================\n");

            changeNum = (Planets)num;
            Console.WriteLine("{0} is {1}", num, changeNum);

            Console.ReadKey();
            
        }
    }
}
