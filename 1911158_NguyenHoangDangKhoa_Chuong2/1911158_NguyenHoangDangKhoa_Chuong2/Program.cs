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
            Console.WriteLine("Ket qua cua {0} + {1} * {2} = {3}", 2, 5, 3, 2 + 5 * 3);
            Console.WriteLine("Ket qua cua {0}/{1} + {2} = {3}", 9, 4, 10, 9 / 4 + 10);
            Console.WriteLine("Ket qua cua {0}/{1} = {2}", 10, 3, 10 / 3);
            Console.WriteLine("Ket qua cua {0}%{1} = {2}", 21, 10, 21 % 10);
            Console.WriteLine("Ket qua cua ({0} - {1}) * {2} = {3}", 5, 1, 3, (5 - 1) * 3);
            Console.WriteLine("Ket qua cua {0} / {1} = {2}", 37, 5, 37/5);
            Console.WriteLine("Ket qua cua {0} % {1} = {2}", 64, 8, 64 % 8);
            Console.WriteLine("Ket qua cua {0} + {1} * {2} - {3} * {4} = {5}", 5, 2, 4, 3, 4, 5 + 2 * 4 - 3 * 4);
            Console.WriteLine("Ket qua cua {0} * ({1} + {2}) / {3} = {4}", 3, 2, 5, 5, 3 * (2 + 5) / 5);
            Console.WriteLine("Ket qua cua {0} % {1} - {2} = {3}", 28, 5, 2, 28 % 5 - 2);
            Console.WriteLine("Ket qua cua {0} / {1} / {2} = {3}", 19, 2, 2, 19 / 2 / 2);
            Console.WriteLine("Ket qua cua {0} / ({1} + {2}) = {3}", 28, 2, 4, 28 / (2 + 4));
            Console.ReadKey();
        }
    }
}
