using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanhInterface
{
    class NhanVienBienChe:NhanVien
    {
        long heSoLuong, luongCoBan;

        public long HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public long LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so luong: ");
            HeSoLuong = long.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban: ");
            LuongCoBan = long.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"He so luong:{HeSoLuong}");
            Console.WriteLine($"Luong co ban:{LuongCoBan}");

        }

        public double PhuCap()
        {
            double P = LuongCoBan / 10;

            return P;
        }
        public double ThucLinh()
        {
            double T = HeSoLuong * LuongCoBan + PhuCap();
            return T;
        }

    }
}
