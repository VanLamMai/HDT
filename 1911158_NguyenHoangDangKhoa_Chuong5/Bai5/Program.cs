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
            int luongHang,
                tongHangD = 0,
                tongHangE = 0,
                tongHangF = 0;
            double soTien,
                   tongTienD = 0,
                   tongTienE = 0,
                   tongTienF = 0;
            char nhanVien = 'q';          
            do
            {                
                while (nhanVien != 'd' && nhanVien != 'D' && nhanVien!= 'e' && nhanVien != 'E' && nhanVien != 'f' && nhanVien != 'F')
                {
                    Console.Clear();
                    Console.WriteLine("======================== HomeSales ========================\n");
                    Console.WriteLine("Nhap z hoac Z de dung nhap va xuat ket qua.");
                    Console.WriteLine("\n-----------------------------------------------------------\n");

                    Console.Write("Nhap D hoac E hoac F de chon nhan vien: ");
                    nhanVien = char.Parse(Console.ReadLine());
                    if (nhanVien == 'z' || nhanVien == 'Z')
                        break;
                    if (nhanVien != 'd' && nhanVien != 'D' && nhanVien != 'e' && nhanVien != 'E' && nhanVien != 'f' && nhanVien != 'F')
                    {
                        Console.WriteLine("\nNhap khong hop le!!! Yeu cau nhap lai!!!\n");
                        Console.ReadKey();
                    }                        
                    if (nhanVien == 'd' || nhanVien == 'D')
                    {
                        Console.Clear();
                        Console.Write("\nNhap so hang ma Danielle da ban duoc: ");
                        luongHang = int.Parse(Console.ReadLine());
                        Console.Write("\nNhap don gia cua mat hang: ");
                        soTien = double.Parse(Console.ReadLine());
                        tongTienD = tongTienD + (luongHang * soTien);
                        tongHangD = tongHangD + luongHang;
                        nhanVien = 'q';
                    }      
                    else if (nhanVien == 'e' || nhanVien == 'E')
                    {
                        Console.Clear();
                        Console.Write("\nNhap so hang ma Edward da ban duoc: ");
                        luongHang = int.Parse(Console.ReadLine());
                        Console.Write("\nNhap don gia cua mat hang: ");
                        soTien = double.Parse(Console.ReadLine());
                        tongTienE = tongTienE + (luongHang * soTien);
                        tongHangE = tongHangE + luongHang;
                        nhanVien = 'q';
                    }
                    else if (nhanVien == 'f' || nhanVien == 'F')
                    {
                        Console.Clear();
                        Console.Write("\nNhap so hang ma Francis da ban duoc: ");
                        luongHang = int.Parse(Console.ReadLine());
                        Console.Write("\nNhap don gia cua mat hang: ");
                        soTien = double.Parse(Console.ReadLine());
                        tongTienF = tongTienF + (luongHang * soTien);
                        tongHangF = tongHangF + luongHang;
                        nhanVien = 'q';
                    }      
                }                     

            } while (nhanVien != 'z' && nhanVien != 'Z');
            Console.WriteLine("\n===========================================================\n");

            Console.WriteLine("Tong so hang ma Danielle ban duoc la: {0} mat hang", tongHangD);
            Console.WriteLine("\nTong so hang ma Edward ban duoc la: {0} mat hang", tongHangE);
            Console.WriteLine("\nTong so hang ma Francis ban duoc la: {0} mat hang", tongHangF);
            Console.WriteLine("\n-----------------------------------------------------------\n");

            Console.WriteLine("Tong so tien ma Danielle ban duoc la: ${0}", tongTienD);
            Console.WriteLine("\nTong so tien ma Edward ban duoc la: ${0}", tongTienE);
            Console.WriteLine("\nTong so tien ma Francis ban duoc la: ${0}", tongTienF);
            Console.WriteLine("\n-----------------------------------------------------------");

            if ((tongTienD > tongTienE && tongTienE > tongTienF) || (tongTienD > tongTienF && tongTienF > tongTienE))
                Console.WriteLine("\nDanielle la nguoi co tong so tien ban duoc cao nhat!!!");
            else if ((tongTienE > tongTienF && tongTienF > tongTienE) || (tongTienE > tongTienD && tongTienD > tongTienF))
                Console.WriteLine("\nEdward la nguoi co tong so tien ban duoc cao nhat!!!");
            else if ((tongTienF > tongTienD && tongTienD > tongTienE) || (tongTienF > tongTienE && tongTienE > tongTienD))
                Console.WriteLine("\nEdward la nguoi co tong so tien ban duoc cao nhat!!!");
            else
                Console.WriteLine("\nKhong co ai la nguoi co tong so tien ban duoc cao nhat!!!");
            Console.ReadKey();
        }
    }
}