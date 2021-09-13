using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static List<Sale> listSale = new List<Sale>();
        static void Main(string[] args)
        {
            CreatList();
            Console.WriteLine("List 10 Sale Objects: ");
            OutList();
            SortListSaleTaxOwed();
            Console.WriteLine("\nList 10 Sale Objects In Order Tax Owed: ");
            OutList();
            Console.ReadKey();
        }

        static void CreatList()
        {
            Sale a;
            for (int i = 0; i < 10; i++)
            {
                a = new Sale(i);
                listSale.Add(a);
            }
        }

        static void OutList()
        {
            foreach (var i in listSale)
                Console.WriteLine(i);
        }

        static void SortListSaleTaxOwed()
        {
            Sale temp;
            for (int i = 0; i < listSale.Count - 1; i++)
            {
                for (int j = i + 1; j < listSale.Count; j++)
                {
                    if (listSale[i].TaxOwed > listSale[j].TaxOwed)
                    {
                        temp = listSale[j];
                        listSale[j] = listSale[i];
                        listSale[i] = temp;
                    }
                }
            }
        }
    }
}
