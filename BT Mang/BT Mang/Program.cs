using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_Mang
{
    class Program
    {
        static string[] ds = new string[]
      {
          "Nguyen Van Dat", "La Quoc Thang", "Ho Thi Mai", "Dinh Trong Thien", 
          "Pham Trung Kien", "Bui Huu Thien", "Nguyen Linh", "Mai Tien Linh",
          "Dinh Trong Bao", "Tran Thanh An", "Nguyen Gia Thang", "Nguyen Thi Bao Tran"
};
        static void Main(string[] args)
        {
            int menu, soMenu = 14;
            do
            {
                menu = ChonMenu(soMenu);
                XuLyMenu(menu);
            } while (menu > 0);
        }
        static void XuatMenu()
        {
            Console.WriteLine("================================ BAI TAP VE MANG ===============================");
            Console.WriteLine("================================   CHUC NANG ===================================");
            Console.WriteLine("0.Thoat khoi chuong trinh");
            Console.WriteLine("1. Tim ten xuat hien nhieu nhat");
            Console.WriteLine("2.Tim ten xuat hien it nhat");
            Console.WriteLine("3.Tim ho co so lan xuat hien la x lan");
            Console.WriteLine("4.Tim ten dai nhat");
            Console.WriteLine("5.Tim ten ngan nhat");
            Console.WriteLine("6.Tim tat ca cac ten bat dau bang ky tu x nao do");
            Console.WriteLine("7.Tim danh sach ten co ho dem dai nhat");
            Console.WriteLine("8.Tim danh sach ten co ho dem ngan nhat");
            Console.WriteLine("9.Tim danh sach ten khong co ho dem");
            Console.WriteLine("10.Thay the tat ca nhung nguoi ten x bang ten y");
            Console.WriteLine("11.Hien thi danh sach theo chieu tang cua ho");
            Console.WriteLine("12.Hien thi danh sach tang theo chieu dai cua ten");
            Console.WriteLine("13.Xem mang hien hanh");
            Console.WriteLine("14.Bo sung cac chuc nang tren vao thuc don");
            Console.WriteLine("=================================== END ======================================");
        }
        static int ChonMenu(int soMenu)
        {
            int stt;
            for(; ; )
            {
                Console.Clear();
                XuatMenu();
                Console.Write("\nNhap mot so trong khoang [0...{0}] de chon chuc nang:", soMenu);
                stt = int.Parse(Console.ReadLine());
                if (0 <= stt && stt <= soMenu)
                    break;
            }
            return stt;
        }
        static void XuLyMenu(int menu)
        {
            switch(menu)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("0.Thoat khoi chuong trinh");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("1.Tim ten xuat hien nhieu nhat");
                    TimTenXuatHienNhieuNhat();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("2.Tim ten xuat hien it nhat");
                    TimTenXuatHienItNhat();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("3.Tim ho co so lan xuat hien la x lan");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("4.Tim ten dai nhat");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("5.Tim ten ngan nhat");
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("6.Tim tat ca cac ten bat dau bang ky tu x nao do");
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("7.Tim danh sach ten co ho dem dai nhat");
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("8.Tim danh sach ten co ho dem ngan nhat");
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("9.Tim danh sach ten khong co ho dem");
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("10.Thay the tat ca nhung nguoi ten x bang ten y");
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("11.Hien thi danh sach theo chieu tang cua ho");
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("12.Hien thi danh sach tang theo chieu dai cua ten");
                    break;
                case 13:
                    Console.Clear();
                    Console.WriteLine("13.Xem mang hien hanh.\n");
                    XuatMang();
                    break;
                case 14:
                    Console.Clear();
                    Console.WriteLine("14.Bo sung cac chuc nang tren vao thuc don");
                    Console.WriteLine("Da bo sung cac chuc nang tren vao thuc don");
                    break;
            }
            Console.ReadKey();
        }
        static void XuatMang()
        {
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine(ds[i]);
            }
        }
        static void TimTenXuatHienNhieuNhat()
        {
            int maxDem = 0, dem;
            string ten = "";
            for (int i = 0; i < ds.Length; i++)
            {
                dem = 1;
                for (int j = i+1 ; j < ds.Length; j++)
                {
                    if (LayTen(ds[i]).CompareTo(LayTen(ds[j])) == 0)
                        dem++;
                }
                if (dem > maxDem)
                    ten = LayTen(ds[i]);
            }
            Console.WriteLine("Ten {0} xuat hien nhieu nhat, so lan xuat hien la {1}", ten, maxDem);
        }
        static void TimTenXuatHienItNhat()
        {
            int minDem = 0, dem;
            string ten = "";
            for (int i = 0; i < ds.Length; i++)
            {
                dem = 1;
                for (int j = i+1; j < ds.Length; j++)
                {
                    if (LayTen(ds[i]).CompareTo(LayTen(ds[j])) == 0)
                        dem++;
                }
                if (dem < minDem)
                    ten = LayTen(ds[i]);
            }
            Console.WriteLine("Ten {0} xuat hien it nhat, so lan xuat hien la {1}", ten, minDem);
        }
        static string LayTen(string hoVaTen)
        {
            string ten;
            hoVaTen = hoVaTen.TrimEnd();
            int vt = hoVaTen.LastIndexOf(' ');
            ten = hoVaTen.Substring(vt, hoVaTen.Length - vt);
            ten = ten.Trim();
            return ten;
        }
    }
}
