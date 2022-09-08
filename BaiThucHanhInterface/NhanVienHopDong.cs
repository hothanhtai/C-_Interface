using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanhInterface
{
    class NhanVienHopDong:NhanVien
    {
        long mucLuong;

        public long MucLuong { get => mucLuong; set => mucLuong = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc luong: ");
            MucLuong = long.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write($"Muc luong: {MucLuong}");
        }
        public double PhuCap()
        {
            double P = MucLuong / 10;

            return P;
        }
        public double ThucLinh()
        {
            double T = MucLuong + PhuCap();
            return T;
        }
    }
}
