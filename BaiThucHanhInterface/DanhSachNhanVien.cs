using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanhInterface
{
    class DanhSachNhanVien:NhanVien
    {
        public Dictionary<string, NhanVien> List = new Dictionary<string, NhanVien>();

        public void NhapNhanVien()
        {

            Console.Write("Nhap so luong nhan vien: ");
            int soLuong = int.Parse(Console.ReadLine());
            for(int i = 0; i< soLuong; i++)
            {
                Console.Write("An phim B tren ban phim de nhap cho nhan vien bien che,An phim H tren ban phim de nhap cho nhan vien hop dong!");
                char c = char.Parse(Console.ReadLine().ToUpper().PadLeft(1));

                switch (c)
                    {
                        case 'B':
                        {
                            NhanVienBienChe nvbc = new NhanVienBienChe();
                            nvbc.Nhap();
                            List.Add(nvbc.MaNv, nvbc);
                        }
                        break;
                        case 'H':
                        {
                            NhanVienHopDong nvhd = new NhanVienHopDong();
                            nvhd.Nhap();
                            List.Add(nvhd.MaNv, nvhd);
                        }
                        break;
                        default:
                        Console.Write("Nhap sai moi nhap lai! \n");

                        break;


                }
            }
        }

        public void In()
        {
            foreach (var item in List.Values)
            {
                Console.WriteLine("====Danh sach nhan vien======");
                item.Xuat();
       
                
            }
        }
       public double TongQuyLuong()
        {
            double tongluong = 0;
            foreach(var i in List.Values)
            {
                if(i is NhanVienBienChe)
                {
                    tongluong += ((NhanVienBienChe)i).ThucLinh();
                }
                else
                    tongluong += ((NhanVienHopDong)i).ThucLinh();
            }
            return tongluong;
        }

        public void Tim()
        {
            Console.Write("Nhap ma nhan vien can tim: ");
            string ma = Console.ReadLine();
            if (List.ContainsKey(ma) == true)
            {
                Console.Write("Co nhan vien can tim!");
                List[ma].Xuat();

            }
            else
            {
                Console.Write("Khong tim thay nhan vien !");
            }
        }

        public void Xoa()
        {
            Console.Write("Nhap ma nhan vien can xoa: ");
            string ma = Console.ReadLine();
            if (List.ContainsKey(ma) == true)
            {
                Console.Write("Co xe can xoa!");
                List.Remove(ma);

            }
            else
            {
                Console.Write("Khong tim thay nhan vien can xoa!");
            }
        }


    }
}
