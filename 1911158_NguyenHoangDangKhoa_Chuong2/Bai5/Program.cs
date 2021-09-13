using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            const float trans = 2.54f;
            float inch1 = 3f, inch2 = 5f;
            float centi1 = inch1 * trans,
                centi2 = inch2 * trans;


            Console.WriteLine("================== InchesToCentmeters ==================");
            Console.WriteLine("{0} inches is {1} centimeters", inch1, centi1);
            Console.WriteLine("{0} inches is {1} centimeters", inch2, centi2);
            Console.ReadKey();
        }
    }
}
