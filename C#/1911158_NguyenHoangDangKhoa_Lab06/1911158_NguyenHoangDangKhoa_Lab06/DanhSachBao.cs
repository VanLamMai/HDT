using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_Lab06
{
    class DanhSachBao
    {
        public List<Bao> dsBao = new List<Bao>();
        
        #region private
        private bool SoSanh(Bao a, Bao b, KieuSapXep kieuSX)
        {
            if (kieuSX == KieuSapXep.SapTang)
                return a.SoTrang > b.SoTrang;
            else
                return a.SoTrang < b.SoTrang;
        }
        #endregion

        #region public
        public void Them(Bao b)
        {
            dsBao.Add(b);
        }

        public int TimSoTrang(KieuTimKiem ktk)
        {
            if (ktk == KieuTimKiem.DaiNhat)
                return dsBao.Max(x => x.SoTrang);
            else
                return dsBao.Min(x => x.SoTrang);
        }

        public void SapXep_SoTrang(KieuSapXep kieuSX)
        {
            for (int i = 0; i < dsBao.Count - 1; i++)
            {
                for (int j = i + 1; j < dsBao.Count; j++)
                {
                    if (SoSanh(dsBao[i], dsBao[j], kieuSX))
                    {
                        Bao tam = dsBao[i];
                        dsBao[i] = dsBao[j];
                        dsBao[j] = tam;
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Danh sach bao: \n");
            foreach (var bao in dsBao)
            {
                sb.Append(bao + "\n");
            }
            return sb.ToString();
        }
        #endregion
    }
}
