using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class DanhSachHinhVuong
    {
        public List<HinhVuong> dsHV;

        public DanhSachHinhVuong()
        {
            dsHV = new List<HinhVuong>();
        }

        public void Them(HinhVuong hv)
        {
            dsHV.Add(hv);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Danh Sach Hinh Vuong: ");
            foreach (var hv in dsHV)
            {
                sb.Append(hv + "\n");
            }
            return sb.ToString();
        }

        public double TimDienTichMax()
        {
            return dsHV.Max(x => x.TinhDienTich());
        }

        public double TimDienTichMin()
        {
            return dsHV.Min(x => x.TinhDienTich());
        }

        public double TimChuViMax()
        {
            return dsHV.Max(x => x.TinhChuVi());
        }

        public double TimChuViMin()
        {
            return dsHV.Min(x => x.TinhChuVi());
        }

        public int TimHinhVuong_MaxDT()
        {
            int vt = -1;
            double maxDT = TimDienTichMax();
            for (int i = 0; i < dsHV.Count; i++)
            {
                if (dsHV[i].TinhDienTich() == maxDT)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhVuong_MinDT()
        {
            int vt = -1;
            double minDT = TimDienTichMin();
            for (int i = 0; i < dsHV.Count; i++)
            {
                if (dsHV[i].TinhDienTich() == minDT)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhVuong_MaxCV()
        {
            int vt = -1;
            double maxCV = TimChuViMax();
            for (int i = 0; i < dsHV.Count; i++)
            {
                if (dsHV[i].TinhChuVi() == maxCV)
                    vt = i;
            }
            return vt;
        }

        public int TimHinhVuong_MinCV()
        {
            int vt = -1;
            double minCV = TimChuViMin();
            for (int i = 0; i < dsHV.Count; i++)
            {
                if (dsHV[i].TinhChuVi() == minCV)
                    vt = i;
            }
            return vt;
        }

        private bool SoSanh_ChuVi(HinhVuong a, HinhVuong b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoChuVi)
            {
                return a.TinhChuVi() > b.TinhChuVi();
            }
            return a.TinhChuVi() < b.TinhChuVi();
        }

        private bool SoSanh_DienTich(HinhVuong a, HinhVuong b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoDienTich)
            {
                return a.TinhDienTich() > b.TinhDienTich();
            }
            return a.TinhDienTich() < b.TinhDienTich();
        }

        public void SapXep_ChuVi(KieuSapXep kieu)
        {
            for (int i = 0; i < dsHV.Count - 1; i++)
            {
                for (int j = i + 1; j < dsHV.Count; j++)
                {
                    if (SoSanh_ChuVi(dsHV[i], dsHV[j], kieu))
                    {
                        HinhVuong tam = dsHV[i];
                        dsHV[i] = dsHV[j];
                        dsHV[j] = tam;
                    }
                }
            }
        }

        public void SapXep_DienTich(KieuSapXep kieu)
        {
            for (int i = 0; i < dsHV.Count - 1; i++)
            {
                for (int j = i + 1; j < dsHV.Count; j++)
                {
                    if (SoSanh_DienTich(dsHV[i], dsHV[j], kieu))
                    {
                        HinhVuong tam = dsHV[i];
                        dsHV[i] = dsHV[j];
                        dsHV[j] = tam;
                    }
                }
            }
        }
    }
}