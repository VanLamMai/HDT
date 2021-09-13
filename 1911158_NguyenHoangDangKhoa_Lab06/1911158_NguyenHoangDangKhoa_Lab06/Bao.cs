using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_Lab06
{
    class Bao
    {
        private int soTrang;
        private string nhaXuatBan;

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

        public Bao()
        {

        }

        public Bao(int soTrang, string nxb)
        {
            this.SoTrang = soTrang;
            this.NhaXuatBan = nxb;
        }

        public void Nhap()
        {
            Console.Write("Nhap so trang: ");
            this.SoTrang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nha xuat ban: ");
            this.NhaXuatBan = Console.ReadLine();
        }

        public override string ToString()
        {
            return string.Format("Bao: {0} Trang, NXB: {1}", SoTrang, NhaXuatBan);
        }
    }
}
