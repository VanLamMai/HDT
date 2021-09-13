using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_Lab06
{
    class Sach
    {
        private string tuaDe;
        private int soTrang;
        private string nhaXuatBan;

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

        public Sach()
        {

        }

        public Sach(string tuaDe, int soTrang, string nxb)
        {
            this.TuaDe = tuaDe;
            this.SoTrang = soTrang;
            this.NhaXuatBan = nxb;
        }

        public void Nhap()
        {
            Console.Write("Nhap tua de sach: ");
            this.TuaDe = Console.ReadLine();
            Console.Write("Nhap so trang cua sach: ");
            this.SoTrang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nha xuat ban: ");
            this.NhaXuatBan = Console.ReadLine();
        }

        public override string ToString()
        {
            return string.Format("Sach: {0}, {1} Trang, NXB: {2}", TuaDe, SoTrang, NhaXuatBan);
        }
    }
}
