using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMang
{
    class Program
    {
        static string[] ds = new string[] {"Nguyen Van Dat", "La Quoc Thang", "Ho Thi Mai", "Dinh Trong Thien", 
                                         "Pham Trung Kien", "Bui Huu Thien", "Nguyen Linh", "Mai Tien Linh",
                                         "Dinh Trong Bao", "Tran Thanh An", "Nguyen Gia An", "Nguyen Thi Bao Tran", 
                                         "Lai Ka", "Nguyen Van La", "Nguyen Thi Bao Anh", "Nguyen Tran Thanh Hoa", 
                                         "Nguyen Tran Thanh Huyen"};
        static void Main(string[] args)
        {
            int menu,
                soMenu = 14;
            do
            {
                menu = ChonMenu(soMenu);
                XuLyMenu(menu);
            } while (menu > 0);
        }

        static void XuatMenu()
        {
            Console.WriteLine("========================= BAI TAP VE MANG =========================");
            Console.WriteLine("============================ CHUC NANG ============================");
            Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
            Console.WriteLine("1. Tim ten xuat hien nhieu nhat.");
            Console.WriteLine("2. Tim ten xuat hien it nhat.");
            Console.WriteLine("3. Tim ho co so lan xuat hien la x lan.");
            Console.WriteLine("4. Tim ten dai nhat.");
            Console.WriteLine("5. Tim ten ngan nhat.");
            Console.WriteLine("6. Tim tat ca cac ten bat dau bang ky tu x nao do.");
            Console.WriteLine("7. Tim danh sach ten co ho dem dai nhat.");
            Console.WriteLine("8. Tim danh sach ten co ho dem ngan nhat.");
            Console.WriteLine("9. Tim danh sach ten khong co ho dem.");
            Console.WriteLine("10. Thay the tat ca nhung nguoi ten x bang ten y.");
            Console.WriteLine("11. Hien thi danh sach theo chieu tang cua ho.");
            Console.WriteLine("12. Hien thi danh sach theo tang chieu dai cua ten.");
            Console.WriteLine("13. Xem mang hien hanh.");
            Console.WriteLine("14. Bo sung cac chuc nang tren vao thuc don.");
            Console.WriteLine("=============================== END ===============================");
        }

        static int ChonMenu(int soMenu)
        {
            int stt;
            for (; ; )
            {
                Console.Clear();
                XuatMenu();
                Console.Write("\nNhap mot so trong khoang [0...{0}] de chon chuc nang: ", soMenu);
                stt = int.Parse(Console.ReadLine());
                if (stt >= 0 && stt <= soMenu)
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
                    Console.WriteLine("1. Tim ten xuat hien nhieu nhat.");
                    TimTenXuatHienNhieuNhat();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("2. Tim ten xuat hien it nhat.");
                    TimTenXuatHienItNhat();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("3. Tim ho co so lan xuat hien la x lan.");
                    TimHoCoSoLanXuatHienX();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("4. Tim ten dai nhat.");
                    XuatTenDaiNhat();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("5. Tim ten ngan nhat.");
                    XuatTenNganNhat();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("6. Tim tat ca cac ten bat dau bang ky tu x nao do.");
                    TimTenBatDauBangKyTuX();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("7. Tim danh sach ten co ho dem dai nhat.");
                    XuatHoDemDaiNhat();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("8. Tim danh sach ten co ho dem ngan nhat.");
                    XuatHoDemNganNhat();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("9. Tim danh sach ten khong co ho dem.");
                    XuatDanhSachKhongHoDem();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("10. Thay the tat ca nhung nguoi ten x bang ten y.");
                    ThayTheTatCaTenXBangTenY();
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("11. Hien thi danh sach theo chieu tang cua ho.");
                    SapXepTheoChieuTangCuaHo();
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("12. Hien thi danh sach theo tang chieu dai cua ten.");
                    SapXepTangTheoChieuDaiCuaTen();
                    break;
                case 13:
                    Console.Clear();
                    Console.WriteLine("13. Xem mang hien hanh.\n");
                    XuatMang();
                    break;
                case 14:
                    Console.Clear();
                    Console.WriteLine("14. Bo sung cac chuc nang tren vao thuc don.");
                    Console.WriteLine("Da bo sung cac chuc nang tren vao thuc don.");
                    break;
            }
            Console.ReadKey();
        }

        //static void TimTenXuatHienNhieuNhat()
        //{
        //    int maxDem = 0,
        //        dem;
        //    string ten = "";
        //    for (int i = 0; i < ds.Length; i++)
        //    {
        //        dem = 1;
        //        for (int j = i + 1; j < ds.Length; j++)
        //        {
        //            if (LayTen(ds[i]).CompareTo(LayTen(ds[j])) == 0)
        //                dem++;
        //        }
        //        if (dem > maxDem)
        //        {
        //            maxDem = dem;
        //            ten = LayTen(ds[i]);
        //        }
        //    }

        //    Console.WriteLine("Ten {0} xuat hien nhieu nhat, so lan xuat hien la {1}", ten, maxDem);
        //}

        //static void TimTenXuatHienItNhat()
        //{
        //    int minDem = 0,
        //        dem;
        //    string ten = "";
        //    for (int i = 0; i < ds.Length; i++)
        //    {
        //        dem = 1;
        //        for (int j = i + 1; j < ds.Length; j++)
        //        {
        //            if (LayTen(ds[i]).CompareTo(LayTen(ds[j])) == 0)
        //                dem++;
        //        }
        //        if (dem < minDem)
        //        {
        //            minDem = dem;
        //            ten = LayTen(ds[i]);
        //        }
        //    }

        //    Console.WriteLine("Ten {0} xuat hien it nhat, so lan xuat hien la {1}", ten, minDem);
        //}        

        static void XuatMang()
        {
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine(ds[i]);
            }
        }
        static void XuatTenDaiNhat()
        {
            int maxTenLenght = TimDoDaiTenDaiNhat();
            string tenTam = "";

            Console.Write("Ten dai nhat trong danh sach la: ");
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayTen(ds[i]).Length == maxTenLenght && tenTam != LayTen(ds[i]))
                {
                    Console.Write(" {0}, ", LayTen(ds[i]));
                    tenTam = LayTen(ds[i]);
                }
            }
        }        
        static void XuatTenNganNhat()
        {
            int minTenLenght = TimDoDaiTenNganNhat();
            string tenTam = "";

            Console.Write("Ten ngan nhat trong danh sach la: ");
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayTen(ds[i]).Length == minTenLenght && tenTam != LayTen(ds[i]))
                {
                    Console.Write(" {0}, ", LayTen(ds[i]));
                    tenTam = LayTen(ds[i]);
                }
            }
        }
        static void XuatHoDemDaiNhat()
        {
            int maxHoDemLenght = TimDoDaiHoDemDaiNhat();

            Console.WriteLine("Danh sach ho va ten co ho dem dai nhat: ");
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length == maxHoDemLenght)
                    Console.WriteLine(ds[i]);
            }
        }
        static void XuatHoDemNganNhat()
        {
            int minHoDemLenght = TimDoDaiHoDemNganNhat();

            Console.WriteLine("Danh sach ho va ten co ho dem ngan nhat: ");
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length == minHoDemLenght)
                    Console.WriteLine(ds[i]);
            }
        }
        static void XuatDanhSachKhongHoDem()
        {
            int kq = 0;
            Console.WriteLine("Danh sach ho va ten khong co ho dem: ");
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHoDem(ds[i]).Length == 0)
                {
                    Console.WriteLine(ds[i]);
                    kq++;
                }
            }
            if (kq == 0)
                Console.WriteLine("Khong co ho va ten nao trong danh sach khong co ho dem.");
        }        

        //=================================================================
        static string LayKyTuDauTienCuaChuoi(string chuoiMuonLay)
        {
            string kyTuDauTien;
            chuoiMuonLay = chuoiMuonLay.Trim();
            kyTuDauTien = chuoiMuonLay.Substring(0, 1);
            return kyTuDauTien;
        }
        static string LayTen(string hoVaTen)
        {
            string ten;
            hoVaTen = hoVaTen.Trim();
            int vt = hoVaTen.LastIndexOf(" ");
            ten = hoVaTen.Substring(vt, hoVaTen.Length - vt);
            ten = ten.Trim();
            return ten;
        }
        static string LayHo(string hoVaTen)
        {
            string ho;
            hoVaTen = hoVaTen.Trim();
            int vt = hoVaTen.IndexOf(" ");
            ho = hoVaTen.Substring(0, vt);
            return ho;
        }
        static string LayHoDem(string hoVaTen)
        {
            int vt1;
            string hoDem;
            hoVaTen = hoVaTen.Trim();
            vt1 = hoVaTen.IndexOf(" ");
            hoDem = hoVaTen.Substring(vt1, hoVaTen.Length - LayHo(hoVaTen).Length - LayTen(hoVaTen).Length);
            hoDem = hoDem.Trim();
            return hoDem;
        }
        //=================================================================

        //=================================================================
        static int DemSoLanXuatHienCuaTen(string tenCanDem)
        {
            int dem = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayTen(ds[i]).CompareTo(tenCanDem) == 0)
                    dem++;
            }
            return dem;
        }
        static int DemSoLanXuatHienCuaHo(string hoCanDem)
        {
            int dem = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                if (LayHo(ds[i]).CompareTo(hoCanDem) == 0)
                    dem++;
            }
            return dem;
        }
        static int DemSoLanXuatHienNhieuNhatCuaTen()
        {
            int dem,
                maxDem = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                dem = DemSoLanXuatHienCuaTen(LayTen(ds[i]));
                if (dem > maxDem)
                    maxDem = dem;
            }
            return maxDem;
        }
        static int DemSoLanXuatHienItNhatCuaTen()
        {
            int dem,
                minDem = 1;
            for (int i = 0; i < ds.Length; i++)
            {
                dem = DemSoLanXuatHienCuaTen(LayTen(ds[i]));
                if (dem < minDem)
                    minDem = dem;
            }
            return minDem;
        }
        //=================================================================

        //=================================================================
        static void TimTenXuatHienNhieuNhat()
        {
            int maxDem = DemSoLanXuatHienNhieuNhatCuaTen(),
                dem;
            string ten = "";
            Console.Write("Ten xuat hien nhieu nhat la: ");
            for (int i = 0; i < ds.Length; i++)
            {
                 dem = DemSoLanXuatHienCuaTen(LayTen(ds[i]));
                 if (dem == maxDem && ten != LayTen(ds[i]))
                 {
                     ten = LayTen(ds[i]);
                     Console.Write(" {0}, ", ten);
                 }                             
            }
            Console.WriteLine("\nSo lan xuat hien la: {0}", maxDem);
        }
        static void TimTenXuatHienItNhat()
        {
            int minDem = DemSoLanXuatHienItNhatCuaTen(),
                dem;
            string ten = "";
            Console.Write("Ten xuat hien it nhat la: ");
            for (int i = 0; i < ds.Length; i++)
            {
                dem = DemSoLanXuatHienCuaTen(LayTen(ds[i]));
                if (dem == minDem && ten != LayTen(ds[i]))
                {
                    ten = LayTen(ds[i]);
                    Console.Write(" {0}, ", ten);
                }
            }
            Console.WriteLine("\nSo lan xuat hien la: {0}", minDem);
        }
        static void TimHoCoSoLanXuatHienX()
        {
            string ho = "";
            int demHo,
                x,
                kq = 0;

            Console.Write("Nhap so lan xuat hien cua ho muon tim: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < ds.Length; i++)
            {
                demHo = DemSoLanXuatHienCuaHo(LayHo(ds[i]));
                if (demHo == x && ho != LayHo(ds[i]))
                {
                    ho = LayHo(ds[i]);
                    Console.WriteLine(LayHo(ds[i]));
                    kq++;
                }               
            }

            if (kq == 0)
                Console.WriteLine("Khong co ho nao trong danh sach co so lan xuat hien la: {0}", x);

        }
        static int TimDoDaiTenDaiNhat()
        {
            int doDaiTenDaiNhat = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                if (doDaiTenDaiNhat < LayTen(ds[i]).Length)
                    doDaiTenDaiNhat = LayTen(ds[i]).Length;
            }
            return doDaiTenDaiNhat;
        }
        static int TimDoDaiTenNganNhat()
        {
            int doDaiTenNganNhat = LayTen(ds[0]).Length;
            for (int i = 1; i < ds.Length; i++)
            {
                if (doDaiTenNganNhat > LayTen(ds[i]).Length)
                    doDaiTenNganNhat = LayTen(ds[i]).Length;
            }
            return doDaiTenNganNhat;
        }
        static int TimDoDaiHoDemDaiNhat()
        {
            int doDaiHoDemDaiNhat = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                if (doDaiHoDemDaiNhat < LayHoDem(ds[i]).Length)
                    doDaiHoDemDaiNhat = LayHoDem(ds[i]).Length;
            }
            return doDaiHoDemDaiNhat;
        }
        static int TimDoDaiHoDemNganNhat()
        {
            int doDaiHoDemNganNhat = LayHoDem(ds[0]).Length;
            for (int i = 1; i < ds.Length; i++)
            {
                if (doDaiHoDemNganNhat > LayHoDem(ds[i]).Length)
                    doDaiHoDemNganNhat = LayHoDem(ds[i]).Length;
            }
            return doDaiHoDemNganNhat;
        }
        static void TimTenBatDauBangKyTuX()
        {
            string kyTu,
                   tenTam = "";
            int kq = 0;

            Console.Write("Nhap ky tu bat dau cua ten: ");
            kyTu = Console.ReadLine();

            kyTu = kyTu.ToLower();

            for (int i = 0; i < ds.Length; i++)
            {
                if (kyTu.CompareTo(LayKyTuDauTienCuaChuoi(LayTen(ds[i])).ToLower()) == 0 && tenTam.CompareTo(LayTen(ds[i]))!= 0)
                {
                    Console.WriteLine(LayTen(ds[i]));
                    tenTam = LayTen(ds[i]);
                    kq++;
                }                    
            }

            if (kq == 0)
                Console.WriteLine("Khong co ten nao trong danh sach co ten bat dau bang ky tu '{0}'", kyTu);
        }
        //=================================================================      

        static bool KiemTraTenTrongDanhSach(string ten)
        {
            for (int i = 0; i < ds.Length; i++)
            {
                if (ten.CompareTo(LayTen(ds[i])) == 0)
                    return true;
            }
            return false;
        }
        static void HoanVi(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        //=================================================================    
        static string ThayTheChuoi(string a, string chuoiCu, string chuoiMoi)
        {
            string b;
            b = a.Replace(chuoiCu, chuoiMoi);
            return b;
        }
        static void ThayTheTatCaTenXBangTenY()
        {
            string tenCu, tenMoi, ten;
            Console.Write("Nhap ten trong danh sach muon thay doi (Viet in chu cai dau tien): ");
            tenCu = Console.ReadLine();
            if (KiemTraTenTrongDanhSach(tenCu) == true)
            {
                Console.Write("Nhap ten moi thay the cho ten '{0}': ", tenCu);
                tenMoi = Console.ReadLine();
                for (int i = 0; i < ds.Length; i++)
                {
                    if (tenCu.ToLower().CompareTo(LayTen(ds[i]).ToLower()) == 0)
                    {
                        ten = LayTen(ds[i]);
                        ten = ThayTheChuoi(ds[i], tenCu, tenMoi);
                        ds[i] = ten;
                    }                        
                }
                Console.WriteLine("Danh sach ho va ten sau khi thay doi: ");
                XuatMang();
            }
            else
                Console.WriteLine("Khong co ai trong danh sach co ten: {0}", tenCu);
        }
        //=================================================================    

        //=================================================================    
        static void SapXepTheoChieuTangCuaHo()
        {
            for (int i = 0; i < ds.Length - 1; i++)
            {
                for (int j = i + 1; j < ds.Length; j++)
                    if (LayHo(ds[i]).CompareTo(LayHo(ds[j])) == 1)
                        HoanVi(ref ds[i], ref ds[j]);
            }
            Console.WriteLine("Danh sach sau khi theo chieu tang cua ho: ");
            XuatMang();
        }
        static void SapXepTangTheoChieuDaiCuaTen()
        {
            for (int i = 0; i < ds.Length - 1; i++)
            {
                for (int j = i + 1; j < ds.Length; j++)
                    if (LayTen(ds[i]).Length > LayTen(ds[j]).Length)
                        HoanVi(ref ds[i], ref ds[j]);
            }
            Console.WriteLine("Danh sach sau khi tang theo chieu dai cua ten: ");
            XuatMang();
        }
    }   
}