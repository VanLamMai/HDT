using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_BaiTapLopDoiTuong_Bai2
{
    class Program
    {
        static DanhSachSinhVien ds = new DanhSachSinhVien();
        static void Main(string[] args)
        {
            ds.NhapTuFile();
            int menu, soMenu = 16;

            do
            {
                menu = ChonMenu(soMenu);
                XuLyMenu(menu);
            } while (menu > 0);
        }

        static void XuatMenu()
        {
            Console.WriteLine("========================= BAI TAP LOP - DOI TUONG =========================");
            Console.WriteLine("================================ CHUC NANG ================================");           
            Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
            Console.WriteLine("1. Xem danh sach sinh vien.");
            Console.WriteLine("2. Dem so luong sinh vien nam trong lop.");
            Console.WriteLine("3. Dem so luong sinh vien nu trong lop.");
            Console.WriteLine("4. Hien thi danh sach sinh vien theo chieu tang cua diem trung binh.");
            Console.WriteLine("5. Hien thi danh sach sinh vien theo chieu giam cua diem trung binh.");
            Console.WriteLine("6. Tim danh sach sinh vien co diem trung binh cao nhat.");
            Console.WriteLine("7. Tim lop co sinh vien co diem trung binh cao nhat.");
            Console.WriteLine("8. Tim lop co sinh vien khong co diem trung binh cao nhat.");
            Console.WriteLine("9. Hien thi danh sach sinh vien theo lop va theo chieu giam cua DTB.");
            Console.WriteLine("10. Xep hang sinh vien cua lop.");
            Console.WriteLine("11. Tim lop co tong diem trung binh cao nhat.");
            Console.WriteLine("12. Tim lop co tong diem trung binh thap nhat.");
            Console.WriteLine("13. Tim lop co nhieu hoc sinh gioi nhat.");
            Console.WriteLine("14. Tim lop co nhieu hoc sinh theo loai yeu, trung binh, kha.");
            Console.WriteLine("15. Ghi xuong file danh sach lop.");
            Console.WriteLine("16. Xem danh sach sinh vien trong file da ghi.");
            Console.WriteLine("=================================== END ===================================");
        }

        static int ChonMenu(int soMenu)
        {
            int stt;
            for (;;)
            {
                Console.Clear();
                XuatMenu();
                Console.Write("Nhap mot so trong khoang tu (0..." + soMenu + ") de chon chuc nang: stt = ");
                stt = int.Parse(Console.ReadLine());
                if (0 <= stt && stt <= soMenu)
                    break;
            }
            return stt;
        }

        static void XuLyMenu(int menu)
        {
            DanhSachSinhVien dsKq = new DanhSachSinhVien();
            List<string> listKq = new List<string>();
            double tongDTB;
            switch (menu)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Xem danh sach sinh vien.");
                    Console.WriteLine(ds);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("2. Dem so luong sinh vien nam trong lop.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    Console.WriteLine("So luong sinh vien nam theo lop: ");
                    ds.DemSoLuongSinhVienNamTheoLop();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("3. Dem so luong sinh vien nu trong lop.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    Console.WriteLine("So luong sinh vien nu theo lop: ");
                    ds.DemSoLuongSinhVienNuTheoLop();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("4. Hien thi danh sach sinh vien theo chieu tang cua diem trung binh.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    ds.SapTangTheoDTB();
                    Console.WriteLine("Danh sach sinh vien sau khi sap tang theo DTB");
                    Console.WriteLine(ds);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("5. Hien thi danh sach sinh vien theo chieu giam cua diem trung binh.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    ds.SapGiamTheoDTB();
                    Console.WriteLine("Danh sach sinh vien sau khi sap giam theo DTB");
                    Console.WriteLine(ds);
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("6. Tim danh sach sinh vien co diem trung binh cao nhat.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    dsKq = ds.TimDanhSachSinhVienCoDTBCaoNhat();
                    Console.WriteLine("Danh sach sinh vien co diem trung binh cao nhat:");
                    Console.WriteLine(dsKq);
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("7. Tim lop co sinh vien co diem trung binh cao nhat.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    Console.Write("Lop co sinh vien co diem trung binh cao nhat la: ");
                    ds.XuatLopCoSinhVienCoDTBCaoNhat();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("8. Tim lop co sinh vien khong co diem trung binh cao nhat.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    Console.Write("Lop co sinh vien khong co diem trung binh cao nhat la: ");
                    ds.XuatLopCoSinhVienKhongCoDTBCaoNhat();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("9. Hien thi danh sach sinh vien theo lop va theo chieu giam cua DTB.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    Console.WriteLine("Nhan phim bat ky de tiep tuc....");
                    Console.ReadKey();
                    Console.Clear();
                    ds.HienThiDanhSachSinhVienTheoLopGiamDTB();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("10. Xep hang sinh vien cua lop.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    Console.WriteLine("Nhan phim bat ky de tiep tuc....");
                    Console.ReadKey();
                    Console.Clear();
                    ds.HienThiThuHangTheoLop();
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("11. Tim lop co tong diem trung binh cao nhat.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    listKq = ds.TimLopCoTongDiemTrungBinhCaoNhat();
                    tongDTB = ds.TimTongDiemTBCaoNhat();
                    Console.Write("Lop co tong diem trung binh cao nhat la: ");
                    XuatListString(listKq);
                    Console.WriteLine("\nTong diem trung binh la: {0}", tongDTB);
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("12. Tim lop co tong diem trung binh thap nhat.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    listKq = ds.TimLopCoTongDiemTrungBinhThapNhat();
                    tongDTB = ds.TimTongDiemTBThapNhat();
                    Console.Write("Lop co tong diem trung binh thap nhat la: ");
                    XuatListString(listKq);
                    Console.WriteLine("\nTong diem trung binh la: {0}", tongDTB);
                    break;
                case 13:
                    Console.Clear();
                    Console.WriteLine("13. Tim lop co nhieu hoc sinh gioi nhat.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    listKq = ds.TimLopCoNhieuHocSinhGioiNhat();
                    Console.Write("Lop co nhieu hoc sinh gioi nhat la: ");
                    XuatListString(listKq);
                    break;
                case 14:
                    Console.Clear();
                    Console.WriteLine("14. Tim lop co nhieu hoc sinh theo loai yeu, trung binh, kha.");
                    Console.WriteLine("Danh sach sinh vien hien hanh:\n");
                    Console.WriteLine(ds);
                    listKq = ds.TimLopCoNhieuHocSinhKhongGioiNhat();
                    Console.Write("Lop co nhieu hoc sinh theo loai yeu, trung binh, kha la: ");
                    XuatListString(listKq);
                    break;
                case 15:
                    Console.Clear();
                    Console.WriteLine("15. Ghi xuong file danh sach lop.");
                    ds.XuatRaFile();
                    Console.WriteLine("Da xuat vao file data1.txt");
                    break;
                case 16:
                    Console.Clear();
                    Console.WriteLine("16. Xem danh sach sinh vien trong file da ghi.");
                    dsKq.NhapTuFileDaGhi();
                    Console.WriteLine("Danh sach sinh vien da duoc ghi vao file:\n");
                    Console.WriteLine(dsKq);
                    break;
            }
            Console.ReadKey();
        }

        static void XuatListString(List<string> list)
        {
            foreach (var item in list)
                Console.Write(item + ", ");
        }        
    }
}