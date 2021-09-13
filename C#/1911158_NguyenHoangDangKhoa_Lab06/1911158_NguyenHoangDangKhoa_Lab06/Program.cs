using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_Lab06
{
    class Program
    {
        static QuanLyAnPham qlap = new QuanLyAnPham();
        static void Main(string[] args)
        {         
            int menu,
                soMenu = 15;

            do
            {
                menu = ChonMenu(soMenu);
                XuLyMenu(menu);
            } while (menu > 0);
        }

        static void XuatMenu()
        {
            Console.WriteLine("============================= QUAN LY AN PHAM =============================");
            Console.WriteLine("============================ HE THONG CHUC NANG ===========================");
            Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
            Console.WriteLine("1. Nhap du lieu bang tay.");
            Console.WriteLine("2. Nhap du lieu tu file.");
            Console.WriteLine("3. Tim an pham co tua de dai nhat.");
            Console.WriteLine("4. Tim an pham co tua de ngan nhat.");
            Console.WriteLine("5. Tim an pham co so trang dai nhat");
            Console.WriteLine("6. Tim an pham co so trang ngan nhat");
            Console.WriteLine("7. Hien thi an pham theo chieu tang cua so trang.");
            Console.WriteLine("8. Hien thi an pham theo chieu giam cua so trang.");
            Console.WriteLine("9. Tim tap chi co so luong bai viet nhieu nhat.");
            Console.WriteLine("10. Tim tap chi co so luong bai viet it nhat.");
            Console.WriteLine("11. Tim nha xuat ban xuat ban nhieu an pham nhat.");
            Console.WriteLine("12. Tim nha xuat ban xuat ban it an pham nhat.");
            Console.WriteLine("13. Hien thi danh sach cac an pham theo nha xuat ban.");
            Console.WriteLine("14. Tim tat ca an pham theo nha xuat ban nao do.");
            Console.WriteLine("15. Xoa tat ca an pham thuoc nha xuat ban nao do.");
            Console.WriteLine("=================================== END ===================================");
        }

        static int ChonMenu(int soMenu)
        {
            int stt;
            bool check;
            for (; ; )
            {
                Console.Clear();
                XuatMenu();
                Console.Write("Nhap mot so trong khoang tu [0..." + soMenu + "] de chon chuc nang, stt = ");
                check = int.TryParse(Console.ReadLine(), out stt);
                if (check)
                    if (0 <= stt && stt <= soMenu)
                        break;
            }
            return stt;
        }

        static void XuLyMenu(int menu)
        {
            switch (menu)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Nhap du lieu bang tay.");
                    qlap.NhapBangTay();
                    qlap.XuatDSAnPham();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("2. Nhap du lieu tu file.");
                    qlap.NhapTuFile();
                    qlap.XuatDSAnPham();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("3. Tim an pham co tua de dai nhat.");
                    qlap.XuatDSAnPham();
                    qlap.TimAnPhamTieuDe(KieuTimKiem.DaiNhat);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("4. Tim an pham co tua de ngan nhat.");
                    qlap.XuatDSAnPham();
                    qlap.TimAnPhamTieuDe(KieuTimKiem.NganNhat);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("5. Tim an pham co so trang dai nhat");
                    qlap.XuatDSAnPham();
                    qlap.TimAnPhamSoTrang(KieuTimKiem.DaiNhat);
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("6. Tim an pham co so trang ngan nhat");
                    qlap.XuatDSAnPham();
                    qlap.TimAnPhamSoTrang(KieuTimKiem.NganNhat);
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("7. Hien thi an pham theo chieu tang cua so trang.");
                    qlap.XuatDSAnPham();
                    WaitToRead();
                    Console.Clear();
                    Console.WriteLine("7. Hien thi an pham theo chieu tang cua so trang.");
                    qlap.HienThiAnPhamSapXepSoTrang(KieuSapXep.SapTang);
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("8. Hien thi an pham theo chieu giam cua so trang.");
                    qlap.XuatDSAnPham();
                    WaitToRead();
                    Console.Clear();
                    Console.WriteLine("8. Hien thi an pham theo chieu giam cua so trang.");
                    qlap.HienThiAnPhamSapXepSoTrang(KieuSapXep.SapGiam);
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("9. Tim tap chi co so luong bai viet nhieu nhat.");
                    qlap.XuatDSAnPham();
                    qlap.TimTapChiTheoSoBaiViet(KieuTimKiem.NhieuNhat);
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("10. Tim tap chi co so luong bai viet it nhat.");
                    qlap.XuatDSAnPham();
                    qlap.TimTapChiTheoSoBaiViet(KieuTimKiem.ItNhat);
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("11. Tim nha xuat ban xuat ban nhieu an pham nhat.");
                    qlap.XuatDSAnPham();
                    qlap.TimNXBXuatBanAnPham(KieuTimKiem.NhieuNhat);
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("12. Tim nha xuat ban xuat ban it an pham nhat.");
                    qlap.XuatDSAnPham();
                    qlap.TimNXBXuatBanAnPham(KieuTimKiem.ItNhat);
                    break;
                case 13:
                    Console.Clear();
                    Console.WriteLine("13. Hien thi danh sach cac an pham theo nha xuat ban.");
                    qlap.XuatDSAnPham();
                    WaitToRead();
                    Console.Clear();
                    Console.WriteLine("13. Hien thi danh sach cac an pham theo nha xuat ban.");
                    qlap.HienThiAnPhamTheoNXB();
                    break;
                case 14:
                    Console.Clear();
                    Console.WriteLine("14. Tim tat ca an pham theo nha xuat ban nao do.");
                    qlap.XuatDSAnPham();
                    qlap.TimAllAnPhamTheoNXB();
                    break;
                case 15:
                    Console.Clear();
                    Console.WriteLine("15. Xoa tat ca an pham thuoc nha xuat ban nao do.");
                    qlap.XuatDSAnPham();
                    qlap.XoaAllAnPhamTheoNXB();
                    WaitToRead();
                    Console.Clear();
                    Console.WriteLine("15. Xoa tat ca an pham thuoc nha xuat ban nao do.");
                    qlap.XuatDSAnPham();
                    break;
            }
            Console.ReadKey();
        }

        static void WaitToRead()
        {
            Console.WriteLine("Nhan phim bat ky de tiep tuc!");
            Console.ReadKey();            
        }
    }
}
