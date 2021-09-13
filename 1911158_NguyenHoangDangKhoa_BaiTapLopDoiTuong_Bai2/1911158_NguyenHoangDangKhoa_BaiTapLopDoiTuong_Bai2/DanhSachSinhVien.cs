using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_BaiTapLopDoiTuong_Bai2
{
    class DanhSachSinhVien
    {
        List<SinhVien> ds = new List<SinhVien>();

        public void ThemSinhVien(SinhVien sv)
        {
            ds.Add(sv);
        }

        public void NhapTuFile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while ((line = sr.ReadLine()) != null)
                ds.Add(new SinhVien(line));
        }

        public void NhapTuFileDaGhi()
        {
            var fileName = "data1.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while ((line = sr.ReadLine()) != null)
                ds.Add(new SinhVien(line));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MSSV".PadRight(15) + "Ho Ten".PadRight(17) + "GT".PadRight(10) + "Lop".PadRight(8) + "DTB\n");
            foreach (var sv in ds)
                sb.Append(sv + "\n");
            return sb.ToString();
        }

        private int DemSoLuongSinhVienTheoGioiTinhVaLop(string gt, string lop)
        {
            int dem = 0;
            foreach (var sv in ds)
            {
                if (sv.GioiTinh.CompareTo(gt) == 0 && sv.Lop.CompareTo(lop) == 0)
                    dem++;
            }
            return dem;
        }

        private List<string> LayDanhSachLop()
        {
            List<string> kq = new List<string>();
            foreach (var sv in ds)
            {
                if (!kq.Contains(sv.Lop))
                    kq.Add(sv.Lop);
            }
            return kq;
        }

        public void DemSoLuongSinhVienNamTheoLop()
        {
            List<string> dsLop = LayDanhSachLop();
            foreach (var lop in dsLop)
                Console.WriteLine("Lop {0}: {1} Nam", lop, DemSoLuongSinhVienTheoGioiTinhVaLop("Nam", lop));
        }

        public void DemSoLuongSinhVienNuTheoLop()
        {
            List<string> dsLop = LayDanhSachLop();
            foreach (var lop in dsLop)
                Console.WriteLine("Lop {0}: {1} Nu", lop, DemSoLuongSinhVienTheoGioiTinhVaLop("Nu", lop));
        }

        enum KieuSapXep
        {
            SapTang,
            SapGiam
        }

        private void SapXepDTB(KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.SapTang)
                ds = ds.OrderBy(x => x.dTB).ToList();
            else if (kieu == KieuSapXep.SapGiam)
                ds = ds.OrderByDescending(x => x.dTB).ToList();
        }

        public void SapTangTheoDTB()
        {
            SapXepDTB(KieuSapXep.SapTang);
        }

        public void SapGiamTheoDTB()
        {
            SapXepDTB(KieuSapXep.SapGiam);
        }

        private double TimDTBCaoNhat()
        {
            return ds.Max(x => x.dTB);
        }

        public DanhSachSinhVien TimDanhSachSinhVienCoDTBCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            double max = TimDTBCaoNhat();
            foreach (var sv in ds)
            {
                if (sv.dTB == max)
                    kq.ThemSinhVien(sv);
            }
            return kq;
        }

        private List<string> TimLopCoSinhVienCoDTBCaoNhat()
        {
            List<string> lop = new List<string>();
            double max = TimDTBCaoNhat();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].dTB == max && !lop.Contains(ds[i].Lop))
                    lop.Add(ds[i].Lop);
            }

            return lop;
        }

        public void XuatLopCoSinhVienCoDTBCaoNhat()
        {
            List<string> lop = new List<string>();
            lop = TimLopCoSinhVienCoDTBCaoNhat();
            foreach (var item in lop)
                Console.Write(item + ", ");
        }

        private List<string> TimLopCoSinhVienKhongCoDTBCaoNhat()
        {
            List<string> kq = new List<string>();
            List<string> lopCaoNhat = TimLopCoSinhVienCoDTBCaoNhat();
            foreach (var item in ds)
            {
                if (!lopCaoNhat.Contains(item.Lop) && !kq.Contains(item.Lop))
                    kq.Add(item.Lop);
            }
            return kq;
        }

        public void XuatLopCoSinhVienKhongCoDTBCaoNhat()
        {
            List<string> lop = new List<string>();
            lop = TimLopCoSinhVienKhongCoDTBCaoNhat();
            foreach (var item in lop)
                Console.Write(item + ", ");
        }

        private DanhSachSinhVien LayDanhSachSinhVienTheoLop(string lop)
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            foreach (var sv in ds)
            {
                if (sv.Lop.CompareTo(lop) == 0)
                    kq.ThemSinhVien(sv);
            }
            return kq;
        }

        public void HienThiDanhSachSinhVienTheoLopGiamDTB()
        {
            List<string> dsLop = LayDanhSachLop();
            DanhSachSinhVien dsSVLop = new DanhSachSinhVien();
            foreach (var lop in dsLop)
            {
                Console.WriteLine("==========================================================");
                Console.WriteLine("Danh sach lop {0}:\n", lop);
                dsSVLop = LayDanhSachSinhVienTheoLop(lop);
                dsSVLop.SapGiamTheoDTB();
                Console.WriteLine(dsSVLop);
            }
        }

        private int TimThuHangCuaMotSinhVien(SinhVien sv)
        {
            int vt = 1;
            foreach(var item in ds)
            {
                if (item.Lop.CompareTo(sv.Lop) == 0 && sv.dTB < item.dTB)
                    vt++;
            }
            return vt;
        }

        private void XepHangSinhVienMotLop(string lop)
        {
            int vt;
            foreach (var sv in ds)
            {
                if (sv.Lop.CompareTo(lop)==0)
                {
                    vt = TimThuHangCuaMotSinhVien(sv);
                    Console.WriteLine("{0}".PadRight(8) + "{1}", sv, vt);
                }              
            }
        }

        public void HienThiThuHangTheoLop()
        {
            List<string> dsLop = LayDanhSachLop();
            foreach (var lop in dsLop)
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("Lop {0}\n", lop);
                Console.Write("MSSV".PadRight(15) + "Ho Ten".PadRight(17) + "GT".PadRight(10) + "Lop".PadRight(8) + "DTB".PadRight(8) + "Hang\n");
                XepHangSinhVienMotLop(lop);
            }
        }

        private double TimTongDiemTBCuaMotLop(string lop)
        {
            double sum = 0;
            foreach (var sv in ds)
            {
                if (sv.Lop.CompareTo(lop) == 0)
                    sum += sv.dTB;
            }
            return sum;
        }

        public double TimTongDiemTBCaoNhat()
        {
            List<string> dsLop = LayDanhSachLop();
            double max = double.MinValue,
                temp;
            foreach (var lop in dsLop)
            {
                temp = TimTongDiemTBCuaMotLop(lop);
                if (max < temp)
                    max = temp;
            }
            return max;

        }

        public double TimTongDiemTBThapNhat()
        {
            List<string> dsLop = LayDanhSachLop();
            double min = double.MaxValue,
                temp;
            foreach (var lop in dsLop)
            {
                temp = TimTongDiemTBCuaMotLop(lop);
                if (min > temp)
                    min = temp;
            }
            return min;
        }


        public List<string> TimLopCoTongDiemTrungBinhCaoNhat()
        {
            double max = TimTongDiemTBCaoNhat();
            List<string> dsLop = LayDanhSachLop();
            List<string> kq = new List<string>();
            foreach (var lop in dsLop)
            {
                if (TimTongDiemTBCuaMotLop(lop) == max)
                    kq.Add(lop);
            }
            return kq;
        }

        public List<string> TimLopCoTongDiemTrungBinhThapNhat()
        {
            double min = TimTongDiemTBThapNhat();
            List<string> dsLop = LayDanhSachLop();
            List<string> kq = new List<string>();
            foreach (var lop in dsLop)
            {
                if (TimTongDiemTBCuaMotLop(lop) == min)
                    kq.Add(lop);
            }
            return kq;
        }

        private int DemSoHocSinhGioiMotLop(string lop)
        {
            int dem = 0;
            int vt;

            foreach (var sv in ds)
            {
                vt = TimThuHangCuaMotSinhVien(sv);
                if (sv.Lop.CompareTo(lop) == 0 && vt == 1)
                    dem++;
            }
            return dem;
        }

        private int DemSoHocSinhKhongGioiMotLop(string lop)
        {
            int dem = 0;
            int vt;

            foreach (var sv in ds)
            {
                vt = TimThuHangCuaMotSinhVien(sv);
                if (sv.Lop.CompareTo(lop) == 0 && vt != 1)
                    dem++;
            }
            return dem;
        }

        private int TimSoHocSinhGioiNhieuNhat()
        {
            int max = int.MinValue,
                temp;
            List<string> dsLop = LayDanhSachLop();
            foreach (var lop in dsLop)
            {
                temp = DemSoHocSinhGioiMotLop(lop);
                if (max < temp)
                    max = temp;
            }
            return max;
        }

        private int TimSoHocSinhKhongGioiNhieuNhat()
        {
            int max = int.MinValue,
                temp;
            List<string> dsLop = LayDanhSachLop();
            foreach (var lop in dsLop)
            {
                temp = DemSoHocSinhKhongGioiMotLop(lop);
                if (max < temp)
                    max = temp;
            }
            return max;
        }

        public List<string> TimLopCoNhieuHocSinhGioiNhat()
        {
            List<string> dsLop = LayDanhSachLop();
            List<string> kq = new List<string>();
            int max = TimSoHocSinhGioiNhieuNhat();
            foreach (var lop in dsLop)
            {
                if (DemSoHocSinhGioiMotLop(lop) == max)
                    kq.Add(lop);
            }
            return kq;
        }

        public List<string> TimLopCoNhieuHocSinhKhongGioiNhat()
        {
            List<string> dsLop = LayDanhSachLop();
            List<string> kq = new List<string>();
            int max = TimSoHocSinhKhongGioiNhieuNhat();
            foreach (var lop in dsLop)
            {
                if (DemSoHocSinhKhongGioiMotLop(lop) == max)
                    kq.Add(lop);
            }
            return kq;
        }

        public void XuatRaFile()
        {
            SinhVien sv = new SinhVien();
            sv.Nhap();
        }
    }
}
