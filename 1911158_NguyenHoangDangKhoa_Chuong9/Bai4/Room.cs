using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Room
    {
        private double length;
        private double width;
        private double height;
        private double area;
        static Random rand = new Random();

        public double Area
        {
            get { return length * height * 2 + width * height * 2; }
        }

        public Room()
        {
            length = rand.Next(8, 50);
            width = rand.Next(8, 50);
            height = rand.Next(3, 6);
        }

        private int Painting()
        {            
            int amount = (int)Area / 350;
            if (Area > 350*amount)
            {
                amount += 1;
            }
            else
                amount = 1;
            return amount;
        }

        public override string ToString()
        {
            return string.Format("Room have {0} length, {1} width, {2} height need: {3} gallons of paint\n Total: {4} square", 
                                  length, width, height, Painting(), Area);
        }
    }
}
