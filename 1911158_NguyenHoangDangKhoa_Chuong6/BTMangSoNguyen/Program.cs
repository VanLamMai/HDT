using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMangSoNguyen
{
    class Program
    {
        static List<int> a = new List<int>(); 
        static void Main(string[] args)
        {
            int menu,
               soMenu = 11;
            NhapMangNgauNhien();
            Console.WriteLine("Danh sach cac phan tu trong mang a: ");
            XuatMang(a);
            Console.ReadKey();
            do
            {
                menu = ChonMenu(soMenu);
                XuLyMenu(menu);
            } while (menu > 0);
        }

        static void XuatMenu()
        {
            Console.WriteLine("===================== BAI TAP MANG SO NGUYEN =====================");            
            Console.WriteLine("=========================== CHUC NANG ============================");            
            Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
            Console.WriteLine("1. Tim so nguyen xuat hien nhieu nhat.");
            Console.WriteLine("2. Tim so nguyen xuat hien it nhat.");
            Console.WriteLine("3. Tim vi tri cua so lon nhat.");
            Console.WriteLine("4. Tim vi tri cua so nho nhat.");
            Console.WriteLine("5. Tim tat ca so chan.");
            Console.WriteLine("6. Tim tat ca so le.");
            Console.WriteLine("7. Kiem tra phan tu x co trong mang hay khong.");
            Console.WriteLine("8. Xoa phan tu tai vi tri x trong danh sach.");
            Console.WriteLine("9. Sap xep mang theo chieu tang.");
            Console.WriteLine("10. Sap xep mang theo chieu giam.");
            Console.WriteLine("11. Bo sung cac chuc nang tren vao thuc don.");
            Console.WriteLine("============================== END ===============================");
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
            List<int> kq = new List<int>();
            int dem,
                max,
                min,
                x;
            switch (menu)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("0. THOAT KHOI CHUONG TRINH.");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Tim so nguyen xuat hien nhieu nhat.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    kq = TimSoNguyenXuatHienNhieuNhat();
                    dem = DemSoLanSoNguyenXuatHienNhieuNhat();
                    Console.WriteLine("\nDanh sach cac so nguyen xuat hien nhieu nhat: ");
                    XuatMang(kq);
                    Console.WriteLine("\nSo lan xuat hien nhieu nhat la: {0}", dem);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("2. Tim so nguyen xuat hien it nhat.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    kq = TimSoNguyenXuatHienItNhat();
                    dem = DemSoLanSoNguyenXuatHienItNhat();
                    Console.WriteLine("\nDanh sach cac so nguyen xuat hien it nhat: ");
                    XuatMang(kq);
                    Console.WriteLine("\nSo lan xuat hien it nhat la: {0}", dem);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("3. Tim vi tri cua so lon nhat.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    max = TimMax();
                    Console.WriteLine("\nSo lon nhat trong mang a la: {0}", max);
                    kq = TimViTriMax();
                    Console.WriteLine("Vi tri cua {0} xuat hien trong mang a la: ", max);
                    XuatMang(kq);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("4. Tim vi tri cua so nho nhat.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    min = TimMin();
                    Console.WriteLine("\nSo nho nhat trong mang a la: {0}", min);
                    kq = TimViTriMin();
                    Console.WriteLine("Vi tri cua {0} xuat hien trong mang a la: ", min);
                    XuatMang(kq);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("5. Tim tat ca so chan.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    kq = TimSoChan();
                    Console.WriteLine("\nDanh sach cac so chan: ");
                    XuatMang(kq);
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("6. Tim tat ca so le.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    kq = TimSoLe();
                    Console.WriteLine("\nDanh sach cac so le: ");
                    XuatMang(kq);
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("7. Kiem tra phan tu x co trong mang hay khong.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    Console.Write("\nNhap phan tu muon tim trong mang: ");
                    x = int.Parse(Console.ReadLine());
                    if (KiemTraXCoTrongMang(x) == 1)
                        Console.WriteLine("{0} co trong mang a", x);
                    else
                        Console.WriteLine("{0} khong co trong mang a", x);
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("8. Xoa phan tu tai vi tri x trong danh sach.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    Console.Write("\nNhap vi tri muon xoa trong mang: ");
                    x = int.Parse(Console.ReadLine());
                    XoaPhanTuTaiViTriX(x);
                    Console.WriteLine("Danh sach cac phan tu trong mang a sau khi xoa tai vi tri {0}: ", x);
                    XuatMang(a);
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("9. Sap xep mang theo chieu tang.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    SapXepMangTheoChieuTang();
                    Console.WriteLine("\nDanh sach cac phan tu trong mang a sau khi duoc sap xep thep chieu tang: ");
                    XuatMang(a);
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("10. Sap xep mang theo chieu giam.");
                    Console.WriteLine("Danh sach cac phan tu trong mang a: ");
                    XuatMang(a);
                    SapXepMangTheoChieuGiam();
                    Console.WriteLine("\nDanh sach cac phan tu trong mang a sau khi duoc sap xep thep chieu giam: ");
                    XuatMang(a);
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("11. Bo sung cac chuc nang tren vao thuc don.");
                    Console.WriteLine("Da bo sung cac chuc nang tren vao thuc don.");
                    break;              
            }
            Console.ReadKey();
        }

        static void NhapMangNgauNhien()
        {
            Console.Write("Nhap chieu dai cua mang: ");
            int length = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < length; i++)
                a.Add(rand.Next(10));
        }

        static void XuatMang(List<int> a)
        {
            foreach (int i in a)
                Console.Write(" {0} ", i);
        }

        static int DemSoLanXuatHienSoNguyen(int item)
        {
            int dem = 0;
            foreach(int i in a)
            {
                if (i == item)
                    dem++;
            }
            return dem;
        }

        static int DemSoLanSoNguyenXuatHienNhieuNhat()
        {
            int maxDem = int.MinValue,
                dem = 0;
            foreach(int i in a)
            {
                dem = DemSoLanXuatHienSoNguyen(i);
                if (maxDem < dem)
                    maxDem = dem;
            }
            return maxDem;
        }

        static int DemSoLanSoNguyenXuatHienItNhat()
        {
            int minDem = int.MaxValue,
                dem;
            foreach (int i in a)
            {
                dem = DemSoLanXuatHienSoNguyen(i);
                if (minDem > dem)
                    minDem = dem;
            }
            return minDem;
        }

        static int TimMax()
        {
            int max = int.MinValue;
            foreach (int i in a)
            {
                if (max < i)
                    max = i;
            }
            return max;
        }
        static int TimMin()
        {
            int min = int.MaxValue;
            foreach (int i in a)
            {
                if (min > i)
                    min = i;
            }
            return min;
        }

        static List<int> TimSoNguyenXuatHienNhieuNhat()
        {
            int maxDem = DemSoLanSoNguyenXuatHienNhieuNhat(),
                dem;
            List<int> kq = new List<int>();
            foreach(int i in a)
            {
                dem = DemSoLanXuatHienSoNguyen(i);
                if (dem == maxDem && kq.Contains(i) == false)
                    kq.Add(i);
            }
            return kq;
        }

        static List<int> TimSoNguyenXuatHienItNhat()
        {
            int minDem = DemSoLanSoNguyenXuatHienItNhat(),
                dem;
            List<int> kq = new List<int>();
            foreach (int i in a)
            {
                dem = DemSoLanXuatHienSoNguyen(i);
                if (dem == minDem && kq.Contains(i) == false)
                    kq.Add(i);
            }
            return kq;
        }       

        static List<int> TimViTriMax()
        {
            int max = TimMax();
            List<int> kq = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == max)
                    kq.Add(i);
            }
            return kq;
        }

        static List<int> TimViTriMin()
        {
            int min = TimMin();
            List<int> kq = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == min)
                    kq.Add(i);
            }
            return kq;
        }

        static List<int> TimSoChan()
        {
            List<int> kq = new List<int>();
            foreach(int i in a)
            {
                if (i%2 == 0)
                    kq.Add(i);
            }
            return kq;
        }

        static List<int> TimSoLe()
        {
            List<int> kq = new List<int>();
            foreach (int i in a)
            {
                if (i % 2 == 1)
                    kq.Add(i);
            }
            return kq;
        }

        static int KiemTraXCoTrongMang(int x)
        {
            foreach (int i in a)
                if (i == x)
                    return 1;            
            return 0;
        }

        static void XoaPhanTuTaiViTriX(int vt)
        {
            a.RemoveAt(vt);
        }

        static void SapXepMangTheoChieuTang()
        {
            for (int i = 0; i < a.Count-1; i++)
            {
                for (int j = i+1; j < a.Count; j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        static void SapXepMangTheoChieuGiam()
        {
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

    }
}