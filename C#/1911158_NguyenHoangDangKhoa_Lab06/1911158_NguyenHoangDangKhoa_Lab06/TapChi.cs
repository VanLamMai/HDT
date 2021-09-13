using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_Lab06
{
    class TapChi
    {
        private string tuaDe;
        private int soTrang;
        private string nhaXuatBan;
        private int soBaiViet;

        public string TuaDe
        {
            get { return tuaDe; }
            set { tuaDe = value.Trim(); }
        }

        public int SoTrang
        {
            get { return soTrang; }
            set
            {
                soTrang = value;
                if (soTrang < 0)
                    soTrang = 1;
            }
        }

        public string NhaXuatBan
        {
            get { return nhaXuatBan; }
            set { nhaXuatBan = value.Trim(); }
        }

        public int SoBaiViet
        {
            get { return soBaiViet; }
            set
            {
                soBaiViet = value;
                if (soBaiViet < 0)
                    soBaiViet = 1;
            }
        }

        public TapChi()
        {

        }

        public TapChi(string tuaDe, int soTrang, string nxb, int soBaiViet)
        {
            this.TuaDe = tuaDe;
            this.SoTrang = soTrang;
            this.NhaXuatBan = nxb;
            this.SoBaiViet = soBaiViet;
        }

        public void Nhap()
        {
            Console.Write("Nhap tua de tap chi: ");
            this.TuaDe = Console.ReadLine();
            Console.Write("Nhap so trang cua tap chi: ");
            this.SoTrang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nha xuat ban: ");
            this.NhaXuatBan = Console.ReadLine();
            Console.Write("Nhap so bai viet: ");
            this.SoBaiViet = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return string.Format("Tap Chi: {0}, {1} Trang, NXB: {2}, So: {3}", TuaDe, SoTrang, NhaXuatBan, SoBaiViet);
        }
    }
}
