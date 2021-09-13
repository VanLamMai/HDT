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
            string carModel;
            double carMile;
            Console.Write("Enter Model Car: ");
            carModel = Console.ReadLine();
            Car carConstruct = new Car(carModel);
            carConstruct.Info();

            Console.Write("Enter Your Car Mile: ");
            carMile = double.Parse(Console.ReadLine());
            Car carUsed = new Car(carModel, carMile);
            Console.WriteLine(carUsed);

            Console.ReadKey();
        }
    }
}
