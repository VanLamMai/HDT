using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3.14151629874651;
            //decimal b = 3.14151629874651; //Khai báo biến b với kiểu decimal không hợp lệ
            decimal c = 3.14151629874651m; //Khai báo biến c với kiểu decimal hợp lệ
            Console.WriteLine("================== DoubleDecimalTest ==================");
            Console.WriteLine("Double a: " + a);
            //Console.WriteLine("Decimal b: " + b);
            Console.WriteLine("Decimal c: " + c);
            Console.ReadKey();
        }
    }
}
