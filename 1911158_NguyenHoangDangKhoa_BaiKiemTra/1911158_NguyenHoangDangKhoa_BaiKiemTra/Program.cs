using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_BaiKiemTra
{
    class Program
    {
        static DSThongTinKhachHang ds = new DSThongTinKhachHang();
        static void Main(string[] args)
        {
            int menu,
                soMenu = 3;
            ds.NhapTuFile();

            do
            {
                menu = ChonMenu(soMenu);
                XuLyMenu(menu);
            } while (menu > 0);
        }

        static void XuatMenu()
        {
            Console.WriteLine("==================== BAI KIEM TRA ====================");
            Console.WriteLine("================= HE THONG CHUC NANG =================");
            Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
            Console.WriteLine("1. Xem danh sach thong tin khach hang.");
            Console.WriteLine("2. Tim thanh pho co nhieu so dien thoai nhat.");
            Console.WriteLine("3. Tim phuong co it so dien thoai nhat.");
            Console.WriteLine("======================== END =========================");
        }

        static int ChonMenu(int soMenu)
        {
            int stt;
            for(;;)
            {
                Console.Clear();
                XuatMenu();
                Console.Write("Nhap mot so trong khoang tu [0..." + soMenu + "] de chon chuc nang: stt = ");
                stt = int.Parse(Console.ReadLine());
                if (0 <= stt && stt <= soMenu)
                    break;
            }
            return stt;
        }

        static void XuLyMenu(int menu)
        {
            List<string> kq = new List<string>();
            switch (menu)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Xem danh sach thong tin khach hang.");
                    Console.WriteLine(ds);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("2. Tim thanh pho co nhieu so dien thoai nhat.");
                    Console.WriteLine("Danh sach thong tin khach hang: ");
                    Console.WriteLine(ds);
                    kq = ds.TimThanhPhoCoNhieuSoDTNhat();
                    Console.WriteLine("\nThanh pho co so dien thoai nhieu nhat la: ");
                    XuatList(kq);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("3. Tim phuong co it so dien thoai nhat.");
                    Console.WriteLine("Danh sach thong tin khach hang: ");
                    Console.WriteLine(ds);
                    kq = ds.TimPhuongCoItSoDTNhat();
                    Console.WriteLine("\nPhuong co so dien thoai it nhat la: ");
                    XuatList(kq);
                    break;
            }
            Console.ReadKey();
        }

        static void XuatList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
