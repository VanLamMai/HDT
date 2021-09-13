using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Shirt
    {
        private string material;

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        private string colour;

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        private string sizeShirt;

        public string SizeShirt
        {
            get { return sizeShirt; }
            set { sizeShirt = value; }
        }

        public Shirt(string mat, string color, string size)
        {
            this.Material = mat;
            this.Colour = color;
            this.SizeShirt = size;
        }

        public override string ToString()
        {
            return string.Format("Material: {0}, Color: {1}, Size: {2}",
                                 this.Material, this.Colour, this.SizeShirt);
        }
    }
}
