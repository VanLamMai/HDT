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
            bool a, b, c, d, e, f, g, h, i, j;
            a = 5 > 4;
            b = 3 <= 3;
            c = 2 + 4 > 5;
            d = 6 == 7;
            e = 2 + 4 <= 6;
            f = 3 + 4 == 4 + 3;
            g = 1 != 2;
            h = 2 != 2;
            i = -5 == 7 - 2;
            j = 3 + 9 <= 0;
            Console.WriteLine("Ket qua cua {0} > {1} la {2}", 5, 4, a);
            Console.WriteLine("Ket qua cua {0} <= {0} la {1}", 3, b);
            Console.WriteLine("Ket qua cua {0} + {1} > {2} la {3}", 2, 4, 5, c);
            Console.WriteLine("Ket qua cua {0} == {1} la {2}", 6, 7, d);
            Console.WriteLine("Ket qua cua {0} + {1} <= {2} la {3}", 2, 4, 6, e);
            Console.WriteLine("Ket qua cua {0} + {1} == {1} + {0} la {2}", 3, 4, f);
            Console.WriteLine("Ket qua cua {0} != {1} la {2}", 1, 2, g);
            Console.WriteLine("Ket qua cua {0} != {0} la {1}", 2, h);
            Console.WriteLine("Ket qua cua {0} == {1} - {2} la {3}", -5, 7, 2, i);
            Console.WriteLine("Ket qua cua {0} + {1} <= {2} la {3}", 3, 9, 0, j);
            Console.ReadKey();

        }
    }
}
