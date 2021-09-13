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
            SoccerPlayer a = new SoccerPlayer();
            a.Nhap();
            Console.WriteLine("====================================================");
            Console.WriteLine("Soccer Player information: ");
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
