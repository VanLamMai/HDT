using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class SalesTransaction
    {
        private string salePersonName;
        private int saleAmmount;
        private double commission;

        public SalesTransaction(string SalePersonName, int SaleAmmount, double CommissonRate)
        {
            salePersonName = SalePersonName;
            saleAmmount = SaleAmmount;
            commission = saleAmmount * CommissonRate;
        }

        public SalesTransaction(string SalePersonName, int SaleAmmount) : this(SalePersonName, SaleAmmount, 0)
        {

        }

        public SalesTransaction(string SalePersonName) : this(SalePersonName, 0, 0)
        {

        }

        public static double operator + (SalesTransaction s1, SalesTransaction s2)
        {
            return s1.saleAmmount + s2.saleAmmount;
        }

        public override string ToString()
        {
            return string.Format("Sale Person Name: {0}, Sale Ammount: {1}, Commisson: {2}", 
                this.salePersonName, this.saleAmmount, this.commission);
        }

    }
}
