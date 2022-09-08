using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanhInterface
{
    class NhanVien
    {
        string hoTen, soCm, maNv,gioiTinh,namSinh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoCm { get => soCm; set => soCm = value; }
        public string MaNv { get => maNv; set => maNv = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }

        public virtual void  Nhap()
        {
            Console.WriteLine("-----Nhap thong tin nhan vien-------");
            Console.Write("Ho va ten :");
            HoTen = Console.ReadLine();
            Console.Write("Nam Sinh :");
            NamSinh = Console.ReadLine();
            Console.Write("Gioi Tinh :");
            GioiTinh = Console.ReadLine();
            Console.Write("So CMND :");
            SoCm = Console.ReadLine();
            Console.Write("Ma Nhan Vien :");
            MaNv = Console.ReadLine();
            Console.WriteLine("\n");

        }

        public virtual void Xuat()
        {
            Console.WriteLine("Thong tin nhan vien da nhap");
            Console.WriteLine("Ho va ten:{0} ", HoTen);
            Console.WriteLine("Nam sinh:{0} ", NamSinh);
            Console.WriteLine("Gioi tinh: {0}",GioiTinh);
            Console.WriteLine("So CMND:{0} ", SoCm);
            Console.WriteLine("Ma nhan vien: {0}", MaNv);
        }
    }

}
