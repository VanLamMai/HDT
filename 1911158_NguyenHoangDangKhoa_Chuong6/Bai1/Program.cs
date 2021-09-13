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
            int menu,
                n = 10,
                soMenu = 4;
            int[] a;
            //int []a = {1,2,3,4,5,6,7,8,9,10};
            a = new int[n];
            InputArray(a, n);
            Console.WriteLine("\nYour Array: ");
            OutputArrayFirstLast(a, n);
            Console.ReadKey();
            do
            {
                menu = ChonMenu(soMenu);
                XuLyMenu(menu, a, n);
            } while (menu < 4);
        }

        static void XuatMenu()
        {
            Console.WriteLine("=========================== ArrayDemo ===========================");
            Console.WriteLine("============================ OPTION =============================");            
            Console.WriteLine("1. View the list in order from the first to last position.");
            Console.WriteLine("2. View the list in order from the last to first position.");
            Console.WriteLine("3. Choose a specific position to view.");
            Console.WriteLine("4. Quit the application.");
            Console.WriteLine("=================================================================");
        }

        static int ChonMenu(int soMenu)
        {
            int stt;
            for (; ;)
            {
                Console.Clear();
                XuatMenu();
                Console.Write("Input One Number From 1 To " + soMenu + ": ");
                stt = int.Parse(Console.ReadLine());
                if (stt >= 1 && stt <= soMenu)
                    break;
            }
            return stt;
        }

        static void XuLyMenu(int menu, int []a, int n)
        {
            int vt;
            switch(menu)
            {              
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. View the list in order from the first to last position.\n");
                    OutputArrayFirstLast(a, n);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("2. View the list in order from the last to first position.\n");
                    OutputArrayLastFirst(a, n);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("3. Choose a specific position to view.\n");
                    Console.Write("Input Position: ");
                    vt = int.Parse(Console.ReadLine());
                    OutPutPosition(a, n, vt);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("4. Quit the application.");
                    break;
            }
            Console.ReadKey();
        }

        static void InputArray(int []a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Input Number {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void OutputArrayFirstLast(int []a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t{0}", a[i]);               
            }
        }

        static void OutputArrayLastFirst(int[] a, int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write("\t{0}", a[i]);
            }
        }

        static void OutPutPosition(int []a, int n, int vt)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == vt)
                    Console.WriteLine("\n a[{0}] = {1}", i, a[i]);
            }
        }
    }
}
