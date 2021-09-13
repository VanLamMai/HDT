using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Car
    {
        private string carModel;
        private double carMile;

        public Car(string CarModel, double CarMile)
        {
            carModel = CarModel;
            carMile = CarMile;
        }

        public Car(string carModel) : this(carModel, 20)
        {

        }

        private int CaculateGallon()
        {
            int mile;
            mile = (int)carMile / 20;
            if (carMile > mile * 20)
                mile++;
            return mile;
        }

        public void Info()
        {
            Console.WriteLine("Car Construct Is {0} Model and {1} Mile Per Gallon", carModel, carMile);
        }

        public override string ToString()
        {
            int gallon = CaculateGallon();
            return string.Format("Model Car: {0}, Mile: {1}, Need {2} gallon", carModel, carMile, gallon);
        }
    }
}
