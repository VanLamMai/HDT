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
            double soTien, max;
            char nhanVien = 'q';

            string[] salesPersonName = new string[] { "Danielle", "Edward", "Francis" };
            double[] tongTien = new double[] { 0, 0, 0 };

            do
            {
                while (nhanVien != 'd' && nhanVien != 'D' && nhanVien != 'e' && nhanVien != 'E' && nhanVien != 'f' && nhanVien != 'F')
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
                        Console.Write("\nNhap so hang ma {0} da ban duoc: ", salesPersonName[0]);
                        luongHang = int.Parse(Console.ReadLine());
                        Console.Write("\nNhap don gia cua mat hang: ");
                        soTien = double.Parse(Console.ReadLine());
                        tongTien[0] = tongTien[0] + (luongHang * soTien);
                        tongHangD = tongHangD + luongHang;
                        nhanVien = 'q';
                    }
                    else if (nhanVien == 'e' || nhanVien == 'E')
                    {
                        Console.Clear();
                        Console.Write("\nNhap so hang ma {0} da ban duoc: ", salesPersonName[1]);
                        luongHang = int.Parse(Console.ReadLine());
                        Console.Write("\nNhap don gia cua mat hang: ");
                        soTien = double.Parse(Console.ReadLine());
                        tongTien[1] = tongTien[1] + (luongHang * soTien);
                        tongHangE = tongHangE + luongHang;
                        nhanVien = 'q';
                    }
                    else if (nhanVien == 'f' || nhanVien == 'F')
                    {
                        Console.Clear();
                        Console.Write("\nNhap so hang ma {0} da ban duoc: ", salesPersonName[2]);
                        luongHang = int.Parse(Console.ReadLine());
                        Console.Write("\nNhap don gia cua mat hang: ");
                        soTien = double.Parse(Console.ReadLine());
                        tongTien[2] = tongTien[2] + (luongHang * soTien);
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

            Console.WriteLine("Tong so tien ma Danielle ban duoc la: ${0}", tongTien[0]);
            Console.WriteLine("\nTong so tien ma Edward ban duoc la: ${0}", tongTien[1]);
            Console.WriteLine("\nTong so tien ma Francis ban duoc la: ${0}", tongTien[2]);
            Console.WriteLine("\n-----------------------------------------------------------");

            max = tongTien[0];

            for (int i = 0; i < tongTien.Length;i++ )
            {
                if (max < tongTien[i])
                    max = tongTien[i];
            }

            if (max == tongTien[0] && max == tongTien[1] && max == tongTien[2])
                Console.WriteLine("\nKhong co ai la nguoi co tong so tien ban duoc cao nhat!!!");
            else if (max == tongTien[0])
                Console.WriteLine("\nDanielle la nguoi co tong so tien ban duoc cao nhat!!!");
            else if (max == tongTien[1])
                Console.WriteLine("\nEdward la nguoi co tong so tien ban duoc cao nhat!!!");
            else if (max == tongTien[2])
                Console.WriteLine("Francis la nguoi co tong so tien ban duoc cao nhat!!!");           
            else
                Console.WriteLine("\nKhong co ai la nguoi co tong so tien ban duoc cao nhat!!!");
            Console.ReadKey();
        }
    }
}