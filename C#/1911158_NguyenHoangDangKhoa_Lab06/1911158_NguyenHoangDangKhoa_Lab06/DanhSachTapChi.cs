using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_Lab06
{
    class DanhSachTapChi
    {
        public List<TapChi> dsTapChi = new List<TapChi>();

        #region private
        private bool SoSanh(TapChi a, TapChi b, KieuSapXep kieuSX)
        {
            if (kieuSX == KieuSapXep.SapTang)
                return a.SoTrang > b.SoTrang;
            else
                return a.SoTrang < b.SoTrang;
        }

        private int TimSoLuongBaiViet(KieuTimKiem kieuTK)
        {
            if (kieuTK == KieuTimKiem.NhieuNhat)
                return dsTapChi.Max(x => x.SoBaiViet);
            else
                return dsTapChi.Min(x => x.SoBaiViet);
        }
        #endregion

        #region public
        public void Them(TapChi tc)
        {
            dsTapChi.Add(tc);
        }

        public int TimDoDaiTieuDe(KieuTimKiem ktk)
        {
            if (dsTapChi.Count != 0 && ktk == KieuTimKiem.DaiNhat)
                return dsTapChi.Max(x => x.TuaDe.Length);
            else if (dsTapChi.Count != 0 && ktk == KieuTimKiem.NganNhat)
                return dsTapChi.Min(x => x.TuaDe.Length);
            else
                return 0;
        }

        public int TimSoTrang(KieuTimKiem ktk)
        {
            if (ktk == KieuTimKiem.DaiNhat)
                return dsTapChi.Max(x => x.SoTrang);
            else
                return dsTapChi.Min(x => x.SoTrang);
        }

        public void SapXep_SoTrang(KieuSapXep kieuSX)
        {
            for (int i = 0; i < dsTapChi.Count - 1; i++)
            {
                for (int j = i + 1; j < dsTapChi.Count; j++)
                {
                    if (SoSanh(dsTapChi[i], dsTapChi[j], kieuSX))
                    {
                        TapChi tam = dsTapChi[i];
                        dsTapChi[i] = dsTapChi[j];
                        dsTapChi[j] = tam;
                    }
                }
            }
        }

        public List<TapChi> TimTapChi_SoBaiViet(KieuTimKiem kieuTK)
        {
            int soBaiViet;
            List<TapChi> kq = new List<TapChi>();
            if (kieuTK == KieuTimKiem.NhieuNhat)
                soBaiViet = TimSoLuongBaiViet(kieuTK);
            else
                soBaiViet = TimSoLuongBaiViet(kieuTK);

            foreach (var tapChi in dsTapChi)
                if (tapChi.SoBaiViet == soBaiViet && !kq.Contains(tapChi))
                    kq.Add(tapChi);
            return kq;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Danh sach tap chi: \n");
            foreach (var tapChi in dsTapChi)
            {
                sb.Append(tapChi + "\n");
            }
            return sb.ToString();
        }
        #endregion
    }
}
