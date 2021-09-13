using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class DanhSachHinhChuNhat
    {
        public List<HinhChuNhat> dsHCN;

        public DanhSachHinhChuNhat()
        {
            dsHCN = new List<HinhChuNhat>();
        }

        public void Them(HinhChuNhat hcn)
        {
            dsHCN.Add(hcn);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Danh Sach Hinh Chu Nhat: ");
            foreach (var hcn in dsHCN)
            {
                sb.Append(hcn + "\n");
            }
            return sb.ToString();
        }

        public double TimDienTichMax()
        {
            return dsHCN.Max(x => x.TinhDienTich());
        }

        public double TimDienTichMin()
        {
            return dsHCN.Min(x => x.TinhDienTich());
        }

        public double TimChuViMax()
        {
            return dsHCN.Max(x => x.TinhChuVi());
        }

        public double TimChuViMin()
        {
            return dsHCN.Min(x => x.TinhChuVi());
        }

        public int TimHinhChuNhat_MinDT()
        {
            int vt = -1;
            double minDT = TimDienTichMin();
            for (int i = 0; i < dsHCN.Count; i++)
            {
                if (dsHCN[i].TinhDienTich() == minDT)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhChuNhat_MaxDT()
        {
            int vt = -1;
            double maxDT = TimDienTichMax();
            for (int i = 0; i < dsHCN.Count; i++)
            {
                if (dsHCN[i].TinhDienTich() == maxDT)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhChuNhat_MinCV()
        {
            int vt = -1;
            double minCV = TimChuViMin();
            for (int i = 0; i < dsHCN.Count; i++)
            {
                if (dsHCN[i].TinhChuVi() == minCV)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhChuNhat_MaxCV()
        {
            int vt = -1;
            double maxCV = TimChuViMax();
            for (int i = 0; i < dsHCN.Count; i++)
            {
                if (dsHCN[i].TinhChuVi() == maxCV)
                    vt = i;
            }
            return vt;
        }

        private bool SoSanh_ChuVi(HinhChuNhat a, HinhChuNhat b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoChuVi)
            {
                return a.TinhChuVi() > b.TinhChuVi();
            }
            return a.TinhChuVi() < b.TinhChuVi();
        }

        private bool SoSanh_DienTich(HinhChuNhat a, HinhChuNhat b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoDienTich)
            {
                return a.TinhDienTich() > b.TinhDienTich();
            }
            return a.TinhDienTich() < b.TinhDienTich();
        }

        public void SapXep_ChuVi(KieuSapXep kieu)
        {
            for (int i = 0; i < dsHCN.Count - 1; i++)
            {
                for (int j = i + 1; j < dsHCN.Count; j++)
                {
                    if (SoSanh_ChuVi(dsHCN[i], dsHCN[j], kieu))
                    {
                        HinhChuNhat tam = dsHCN[i];
                        dsHCN[i] = dsHCN[j];
                        dsHCN[j] = tam;
                    }
                }
            }
        }

        public void SapXep_DienTich(KieuSapXep kieu)
        {
            for (int i = 0; i < dsHCN.Count - 1; i++)
            {
                for (int j = i + 1; j < dsHCN.Count; j++)
                {
                    if (SoSanh_DienTich(dsHCN[i], dsHCN[j], kieu))
                    {
                        HinhChuNhat tam = dsHCN[i];
                        dsHCN[i] = dsHCN[j];
                        dsHCN[j] = tam;
                    }
                }
            }
        }
    }
}
