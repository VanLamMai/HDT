using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            const float trans = 2.54f;
            float inch,
                centi;
            Console.WriteLine("================== InchesToCentmeterslnteractive ==================");
            Console.Write("Nhap do dai inch muon chuyen doi: inch = ");
            inch = float.Parse(Console.ReadLine());
            centi = inch * trans;
            Console.WriteLine("Ket qua sau khi chuyen doi inches sang centimeters:");
            Console.WriteLine("{0} Inches is {1} Centimeters", inch, centi);
            Console.ReadKey();
        }
    }
}
