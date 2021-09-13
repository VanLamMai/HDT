using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class DanhSachHinhTron
    {
        public List<HinhTron> dsHT;

        public DanhSachHinhTron()
        {
            dsHT = new List<HinhTron>();
        }

        public void Them(HinhTron ht)
        {
            dsHT.Add(ht);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Danh Sach Hinh Tron: ");
            foreach (var ht in dsHT)
            {
                sb.Append(ht + "\n");
            }
            return sb.ToString();
        }

        private double TimBanKinh_Max()
        {
            return dsHT.Max(x => x.BanKinh);
        }

        public double TimDienTichMax()
        {
            return dsHT.Max(x => x.TinhDienTich());
        }

        public double TimDienTichMin()
        {
            return dsHT.Min(x => x.TinhDienTich());
        }

        public double TimChuViMax()
        {
            return dsHT.Max(x => x.TinhChuVi());
        }

        public double TimChuViMin()
        {
            return dsHT.Min(x => x.TinhChuVi());
        }

        public int TimHinhTron_MinDT()
        {
            int vt = -1;
            double minDT = TimDienTichMin();
            for (int i = 0; i < dsHT.Count; i++)
            {
                if (dsHT[i].TinhDienTich() == minDT)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhTron_MaxDT()
        {
            int vt = -1;
            double maxDT = TimDienTichMax();
            for (int i = 0; i < dsHT.Count; i++)
            {
                if (dsHT[i].TinhDienTich() == maxDT)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhTron_MinCV()
        {
            int vt = -1;
            double minCV = TimChuViMin();
            for (int i = 0; i < dsHT.Count; i++)
            {
                if (dsHT[i].TinhChuVi() == minCV)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhTron_MaxCV()
        {
            int vt = -1;
            double maxCV = TimChuViMax();
            for (int i = 0; i < dsHT.Count; i++)
            {
                if (dsHT[i].TinhChuVi() == maxCV)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhTron_BK_Max()
        {
            int vt = -1;
            double max_BK = TimBanKinh_Max();
            for (int i = 0; i < dsHT.Count; i++)
            {
                if (dsHT[i].BanKinh == max_BK)
                    vt = i;
            }
            return vt;
        }

        private bool SoSanh_ChuVi(HinhTron a, HinhTron b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoChuVi)
            {
                return a.TinhChuVi() > b.TinhChuVi();
            }
            return a.TinhChuVi() < b.TinhChuVi();
        }

        private bool SoSanh_DienTich(HinhTron a, HinhTron b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoDienTich)
            {
                return a.TinhDienTich() > b.TinhDienTich();
            }
            return a.TinhDienTich() < b.TinhDienTich();
        }

        public void SapXep_ChuVi(KieuSapXep kieu)
        {
            for (int i = 0; i < dsHT.Count - 1; i++)
            {
                for (int j = i + 1; j < dsHT.Count; j++)
                {
                    if (SoSanh_ChuVi(dsHT[i], dsHT[j], kieu))
                    {
                        HinhTron tam = dsHT[i];
                        dsHT[i] = dsHT[j];
                        dsHT[j] = tam;
                    }
                }
            }
        }

        public void SapXep_DienTich(KieuSapXep kieu)
        {
            for (int i = 0; i < dsHT.Count - 1; i++)
            {
                for (int j = i + 1; j < dsHT.Count; j++)
                {
                    if (SoSanh_DienTich(dsHT[i], dsHT[j], kieu))
                    {
                        HinhTron tam = dsHT[i];
                        dsHT[i] = dsHT[j];
                        dsHT[j] = tam;
                    }
                }
            }
        }
    }
}
