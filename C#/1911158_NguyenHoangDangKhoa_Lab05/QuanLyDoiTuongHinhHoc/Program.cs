using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class Program
    {
        static QuanLyHinhHoc qlHH = new QuanLyHinhHoc();
        static void Main(string[] args)
        {
            #region comment
            //qlHH.NhapTuFile();
            //qlHH.XuatDanhSachHinhHoc();
            //qlHH.XoaHinhCo_CV_Min();
            //qlHH.XuatDanhSachHinhHoc();
            //qlHH.HienThiSapXep(KieuHienThi.TangDienTich);
            //qlHH.HienThiSapXep(KieuHienThi.GiamChuVi);
            //qlHH.NhapBangTay();
            //qlHH.XuatDanhSachHinhHoc();
            //qlHH.TimHinhVuong_DT_Max();
            //qlHH.TimHinhChuNhat_DT_Min();
            //qlHH.TimHinhTron_BK_Max();
            //qlHH.SapXepTangChuVi(LoaiHinh.HinhVuong);
            //qlHH.SapXepGiamChuVi(LoaiHinh.HinhChuNhat);
            //qlHH.SapXepTangChuVi(LoaiHinh.HinhTron);
            //qlHH.XuatDanhSachHinhHoc();
            //qlHH.TimHinh_Min_CV();
            #endregion
            int menu, 
                soMenu = 23;

            do
            {
                menu = ChonMenu(soMenu);
                XuLyMenu(menu);
            } while (menu > 0);
        }

        static void XuatMenu()
        {
            Console.WriteLine("============================== LAB 05 ==============================");
            Console.WriteLine("======================== HE THONG CHUC NANG ========================");
            Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
            Console.WriteLine("1. Nhap du lieu bang tay.");
            Console.WriteLine("2. Nhap du lieu tu file.");
            Console.WriteLine("====================================================================");
            Console.WriteLine("3. Tim hinh vuong co dien tich lon nhat.");
            Console.WriteLine("4. Tim hinh chu nhat co dien tich nho nhat.");
            Console.WriteLine("5. Tim hinh tron co ban kinh lon nhat.");
            Console.WriteLine("====================================================================");
            Console.WriteLine("6. Sap xep danh sach hinh vuong theo chieu tang cua chu vi.");
            Console.WriteLine("7. Sap xep danh sach hinh vuong theo chieu giam cua chu vi.");
            Console.WriteLine("8. Sap xep danh sach hinh tron theo chieu tang cua chu vi.");
            Console.WriteLine("9. Sap xep danh sach hinh tron theo chieu giam cua chu vi.");
            Console.WriteLine("10. Sap xep danh sach hinh chu nhat theo chieu tang cua chu vi.");
            Console.WriteLine("11. Sap xep danh sach hinh chu nhat theo chieu giam cua chu vi.");
            Console.WriteLine("====================================================================");
            Console.WriteLine("12. Tim cac hinh co dien tich lon nhat.");
            Console.WriteLine("13. Tim cac hinh co dien tich nho nhat.");
            Console.WriteLine("14. Tim cac hinh co chu vi lon nhat.");
            Console.WriteLine("15. Tim cac hinh co chu vi nho nhat.");
            Console.WriteLine("====================================================================");
            Console.WriteLine("16. Hien thi tat ca cac hinh theo chieu tang cua dien tich.");
            Console.WriteLine("17. Hien thi tat ca cac hinh theo chieu giam cua dien tich.");
            Console.WriteLine("18. Hien thi tat ca cac hinh theo chieu tang cua chu vi.");
            Console.WriteLine("19. Hien thi tat ca cac hinh theo chieu giam cua chu vi.");
            Console.WriteLine("====================================================================");
            Console.WriteLine("20. Xoa cac hinh co dien tich nho nhat.");
            Console.WriteLine("21. Xoa cac hinh co dien tich lon nhat.");
            Console.WriteLine("22. Xoa cac hinh co chu vi nho nhat.");
            Console.WriteLine("23. Xoa cac hinh co chu vi lon nhat.");
            Console.WriteLine("=============================== END ================================");
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
                    Console.WriteLine("0. THOAT KHOI CHUONG TRINH.\n");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Nhap du lieu bang tay.\n");
                    qlHH.NhapBangTay();
                    Console.Clear();
                    XuatDSHinhHoc();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("2. Nhap du lieu tu file.\n");
                    qlHH.NhapTuFile();
                    XuatDSHinhHoc();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("3. Tim hinh vuong co dien tich lon nhat.\n");
                    XuatDSHinhHoc();
                    qlHH.TimHinhVuong_DT_Max();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("4. Tim hinh chu nhat co dien tich nho nhat.\n");
                    XuatDSHinhHoc();
                    qlHH.TimHinhChuNhat_DT_Min();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("5. Tim hinh tron co ban kinh lon nhat.\n");
                    XuatDSHinhHoc();
                    qlHH.TimHinhTron_BK_Max();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("6. Sap xep danh sach hinh vuong theo chieu tang cua chu vi.\n");
                    XuatDSHinhHoc();
                    qlHH.SapXepTangChuVi(LoaiHinh.HinhVuong);
                    Console.WriteLine("Danh sach hinh vuong sau khi sap xep:\n");
                    qlHH.XuatDanhSachTheoLoaiHinh(LoaiHinh.HinhVuong);
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("7. Sap xep danh sach hinh vuong theo chieu giam cua chu vi.\n");
                    XuatDSHinhHoc();
                    qlHH.SapXepGiamChuVi(LoaiHinh.HinhVuong);
                    Console.WriteLine("Danh sach hinh vuong sau khi sap xep:\n");
                    qlHH.XuatDanhSachTheoLoaiHinh(LoaiHinh.HinhVuong);
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("8. Sap xep danh sach hinh tron theo chieu tang cua chu vi.\n");
                    XuatDSHinhHoc();
                    qlHH.SapXepTangChuVi(LoaiHinh.HinhTron);
                    Console.WriteLine("Danh sach hinh tron sau khi sap xep:\n");
                    qlHH.XuatDanhSachTheoLoaiHinh(LoaiHinh.HinhTron);
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("9. Sap xep danh sach hinh tron theo chieu giam cua chu vi.\n");
                    XuatDSHinhHoc();
                    qlHH.SapXepGiamChuVi(LoaiHinh.HinhTron);
                    Console.WriteLine("Danh sach hinh tron sau khi sap xep:\n");
                    qlHH.XuatDanhSachTheoLoaiHinh(LoaiHinh.HinhTron);
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("10. Sap xep danh sach hinh chu nhat theo chieu tang cua chu vi.");
                    XuatDSHinhHoc();
                    qlHH.SapXepTangChuVi(LoaiHinh.HinhChuNhat);
                    Console.WriteLine("Danh sach hinh chu nhat sau khi sap xep:\n");
                    qlHH.XuatDanhSachTheoLoaiHinh(LoaiHinh.HinhChuNhat);
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("11. Sap xep danh sach hinh chu nhat theo chieu giam cua chu vi.");
                    XuatDSHinhHoc();
                    qlHH.SapXepGiamChuVi(LoaiHinh.HinhChuNhat);
                    Console.WriteLine("Danh sach hinh chu nhat sau khi sap xep:\n");
                    qlHH.XuatDanhSachTheoLoaiHinh(LoaiHinh.HinhChuNhat);
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("12. Tim cac hinh co dien tich lon nhat.\n");
                    XuatDSHinhHoc();
                    qlHH.HienThiHinhMaxDT();
                    //qlHH.TimHinh_Max_DT();
                    break;
                case 13:
                    Console.Clear();
                    Console.WriteLine("13. Tim cac hinh co dien tich nho nhat.\n");
                    XuatDSHinhHoc();
                    qlHH.HienThiHinhMinDT();
                    //qlHH.TimHinh_Min_DT();
                    break;
                case 14:
                    Console.Clear();
                    Console.WriteLine("14. Tim cac hinh co chu vi lon nhat.\n");
                    XuatDSHinhHoc();
                    qlHH.HienThiHinhMaxCV();
                    //qlHH.TimHinh_Max_CV();
                    break;
                case 15:
                    Console.Clear();
                    Console.WriteLine("15. Tim cac hinh co chu vi nho nhat.\n");
                    XuatDSHinhHoc();
                    qlHH.HienThiHinhMinCV();
                    //qlHH.TimHinh_Min_CV();
                    break;
                case 16:
                    Console.Clear();
                    Console.WriteLine("16. Hien thi tat ca cac hinh theo chieu tang cua dien tich.\n");
                    XuatDSHinhHoc();
                    Console.WriteLine("Nhan phim bat ky de tiep tuc!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("16. Hien thi tat ca cac hinh theo chieu tang cua dien tich.\n");
                    Console.WriteLine("Danh sach sau khi da sap xep:\n");
                    qlHH.HienThiSapXep(KieuHienThi.TangDienTich);
                    break;
                case 17:
                    Console.Clear();
                    Console.WriteLine("17. Hien thi tat ca cac hinh theo chieu giam cua dien tich.\n");
                    XuatDSHinhHoc();
                    Console.WriteLine("Nhan phim bat ky de tiep tuc!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("17. Hien thi tat ca cac hinh theo chieu giam cua dien tich.\n");
                    Console.WriteLine("Danh sach sau khi da sap xep:\n");
                    qlHH.HienThiSapXep(KieuHienThi.GiamDienTich);
                    break;
                case 18:
                    Console.Clear();
                    Console.WriteLine("18. Hien thi tat ca cac hinh theo chieu tang cua chu vi.\n");
                    XuatDSHinhHoc();
                    Console.WriteLine("Nhan phim bat ky de tiep tuc!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("18. Hien thi tat ca cac hinh theo chieu tang cua chu vi.\n");
                    Console.WriteLine("Danh sach sau khi da sap xep:\n");
                    qlHH.HienThiSapXep(KieuHienThi.TangChuVi);
                    break;
                case 19:
                    Console.Clear();
                    Console.WriteLine("19. Hien thi tat ca cac hinh theo chieu giam cua chu vi.\n");
                    XuatDSHinhHoc();
                    Console.WriteLine("Nhan phim bat ky de tiep tuc!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("19. Hien thi tat ca cac hinh theo chieu giam cua chu vi.\n");
                    Console.WriteLine("Danh sach sau khi da sap xep:\n");
                    qlHH.HienThiSapXep(KieuHienThi.GiamChuVi);
                    break;
                case 20:
                    Console.Clear();
                    Console.WriteLine("20. Xoa cac hinh co dien tich nho nhat.\n");
                    XuatDSHinhHoc();
                    qlHH.XoaHinhCo_DT_Min();
                    Console.WriteLine("Nhan phim bat ky de tiep tuc!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("20. Xoa cac hinh co dien tich nho nhat.\n");
                    Console.WriteLine("Danh sach sau khi xoa:\n");
                    XuatDSHinhHoc();
                    break;
                case 21:
                    Console.Clear();
                    Console.WriteLine("21. Xoa cac hinh co dien tich lon nhat.");
                    XuatDSHinhHoc();
                    qlHH.XoaHinhCo_DT_Max();
                    Console.WriteLine("Nhan phim bat ky de tiep tuc!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("21. Xoa cac hinh co dien tich lon nhat.");
                    Console.WriteLine("Danh sach sau khi xoa:\n");
                    XuatDSHinhHoc();
                    break;
                case 22:
                    Console.Clear();
                    Console.WriteLine("22. Xoa cac hinh co chu vi nho nhat.");
                    XuatDSHinhHoc();
                    qlHH.XoaHinhCo_CV_Min();
                    Console.WriteLine("Nhan phim bat ky de tiep tuc!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("22. Xoa cac hinh co chu vi nho nhat.");
                    Console.WriteLine("Danh sach sau khi xoa:\n");
                    XuatDSHinhHoc();
                    break;
                case 23:
                    Console.Clear();
                    Console.WriteLine("23. Xoa cac hinh co chu vi lon nhat.");
                    XuatDSHinhHoc();
                    qlHH.XoaHinhCo_CV_Max();
                    Console.WriteLine("Nhan phim bat ky de tiep tuc!!!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("23. Xoa cac hinh co chu vi lon nhat.");
                    Console.WriteLine("Danh sach sau khi xoa:\n");
                    XuatDSHinhHoc();
                    break;
            }
            Console.ReadKey();
        }

        static void XuatDSHinhHoc()
        {
            Console.WriteLine("Danh sach hinh hoc hien hanh: ");
            qlHH.XuatDanhSachHinhHoc();
        }
    }
}