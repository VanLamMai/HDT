using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class ClassifiedAd
    {
        public string category { get; set; }
        public int numWords { get; set; }
        public double Price
        {
            get { return numWords * 0.09; }
        }
    }           

    
}
