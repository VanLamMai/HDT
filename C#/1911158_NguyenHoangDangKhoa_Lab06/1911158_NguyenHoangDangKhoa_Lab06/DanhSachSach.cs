using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_Lab06
{
    class DanhSachSach
    {
        public List<Sach> dsSach = new List<Sach>();

        #region private
        private bool SoSanh(Sach a, Sach b, KieuSapXep kieuSX)
        {
            if (kieuSX == KieuSapXep.SapTang)
                return a.SoTrang > b.SoTrang;
            else
                return a.SoTrang < b.SoTrang;
        }
        #endregion

        #region public
        public void Them(Sach s)
        {
            dsSach.Add(s);
        }

        public int TimDoDaiTieuDe(KieuTimKiem ktk)
        {
            if (dsSach.Count != 0 && ktk == KieuTimKiem.DaiNhat)
                return dsSach.Max(x => x.TuaDe.Length);
            else if (dsSach.Count != 0 && ktk == KieuTimKiem.NganNhat)
                return dsSach.Min(x => x.TuaDe.Length);
            else
                return 0;
        }

        public int TimSoTrang(KieuTimKiem ktk)
        {
            if (ktk == KieuTimKiem.DaiNhat)
                return dsSach.Max(x => x.SoTrang);
            else
                return dsSach.Min(x => x.SoTrang);
        }

        public void SapXep_SoTrang(KieuSapXep kieuSX)
        {
            for (int i = 0; i < dsSach.Count - 1; i++)
            {
                for (int j = i + 1; j < dsSach.Count; j++)
                {
                    if (SoSanh(dsSach[i], dsSach[j], kieuSX))
                    {
                        Sach tam = dsSach[i];
                        dsSach[i] = dsSach[j];
                        dsSach[j] = tam;
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Danh sach sach: \n");
            foreach (var sach in dsSach)
            {
                sb.Append(sach + "\n");
            }
            return sb.ToString();
        }
        #endregion       
    }
}
