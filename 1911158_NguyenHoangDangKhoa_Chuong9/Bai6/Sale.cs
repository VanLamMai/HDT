using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Sale
    {
        private int inventoryNumber;

        public int InventoryNumber
        {
            get { return inventoryNumber; }
            set { inventoryNumber = value; }
        }

        private int amtSale;

        public int AmtSale
        {
            get { return amtSale; }
            set { amtSale = value; }
        }

        private readonly int taxOwed;

        public int TaxOwed
        {
            get
            {
                if (AmtSale > 100)
                    return 6;
                else
                    return 8;
            }
        }

        #region method

        static Random rand = new Random();

        public Sale(int inventoryNumber)
        {
            InventoryNumber = inventoryNumber;
            AmtSale = rand.Next(20, 500);
        }

        #endregion

        public override string ToString()
        {
            return string.Format("Inventory Number: {0}, Ammount Of Sale: {1}, Tax Owed: {2}", InventoryNumber, AmtSale, TaxOwed);
        }

    }

}
