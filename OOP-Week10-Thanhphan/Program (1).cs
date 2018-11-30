using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week10_Thanhphan
{
    class Program
    {
        class QLNV
        {

            public int SLNV { get; set; }
            public double LuongMax;
            NhanVien[] dsnv;
            public void NhapDS()
            {
                int answ;
                Console.Write("Nhap So Luong NV:");
                SLNV = int.Parse(Console.ReadLine());
                dsnv = new NhanVien[SLNV];
                for (int i = 0; i < SLNV; i++)
                {
                    Console.Write("\nNhap NV {0}\n", i + 1);
                    Console.Write("Nhap loai NV(1-NVKD,2-NVVP):");
                    answ = int.Parse(Console.ReadLine());
                    if (answ == 1)
                    {
                        dsnv[i] = new NVKD();                        
                    }
                    else
                    {
                        dsnv[i] = new NVVP();
                    }
                    dsnv[i].Nhap();
                }
            }
            public void XuatDS()
            {
                Console.Write("MaSo\tTen\t\tLCB\tThem\t\tLuong\n");
                for (int i = 0; i < SLNV; i++)
                {
                    dsnv[i].Xuat();
                }
            }
            public void SapXepTheoLuong()
            {
                IEnumerable<NhanVien> SortedDS = from nv in dsnv
                                             orderby nv.Luong descending
                                             select nv;
                Console.Write("MaSo\tTen\t\tLCB\tHoaHong\t\tLuong\n");
                foreach (NhanVien nv in SortedDS)
                {
                    nv.Xuat();
                }
            }
            public void SapXepTheoTen()
            {
                IEnumerable<NhanVien> SortedDS = from nv in dsnv
                                             orderby nv.CatTen() ascending
                                             select nv;
                Console.Write("MaSo\tTen\t\tLCB\tThem\t\tLuong\n");
                foreach (NhanVien nv in SortedDS)
                {
                    nv.Xuat();
                }
            }
            public void TimLuongLonNhat()
            {
                LuongMax = dsnv[0].Luong;
                for (int i = 1; i < SLNV; i++)
                {
                    if (LuongMax < dsnv[i].Luong)
                    {
                        LuongMax = dsnv[i].Luong;
                    }
                }
                for (int i = 0; i < SLNV; i++)
                {
                    if (dsnv[i].Luong == LuongMax)
                    {
                        dsnv[i].Xuat();
                    }
                }
            }
            public int KiemTraNVTheoTen(string t, int k)
            {
                for (int i = k; i < SLNV; i++)
                {
                    string[] arr = dsnv[i].Ten.Split(' ');
                    int N = arr.Length;
                    if (arr[N - 1].Trim() == t.Trim())
                    {
                        return i;
                    }
                }
                return -1;
            }
            public void TimNVTheoTen()
            {
                string TenMuonTim;
                Console.Write("\nNhap ten NV muon tim:");
                TenMuonTim = Console.ReadLine();
                int dem = 0;
                for (int kq = 0; kq < SLNV; kq++)
                {
                    kq = KiemTraNVTheoTen(TenMuonTim, kq);
                    if (kq == -1)
                    {
                        Console.Write("Khong co Nhan Vien nay trong Cong ty\n");
                        break;
                    }
                    else
                    {
                        dem++;
                        if (dem == 1)
                        {
                            Console.Write("\nThong tin NV can tim kiem:\n");
                            Console.Write("MaSo\tTen\t\tLCB\tThem\t\tLuong\n");
                        }
                        dsnv[kq].Xuat();
                    }
                }
            }
            public void LuongLonHon2000()
            {
                Console.Write("MaSo\tTen\t\tLCB\tThem\t\tLuong\n");
                for (int i = 0; i < SLNV; i++)
                {
                    if (dsnv[i].Luong > 2000)
                        dsnv[i].Xuat();
                }
            }
        }
        static void Main(string[] args)
        {
            //NVKD nvkd = new NVKD();
            QLNV ds = new QLNV();
            ds.NhapDS();
            Console.Write("\nDanh sach nhan vien:\n");
            ds.XuatDS();
            Console.Write("\nDanh sach NV sau khi duoc sap xep (Giam dan theo luong)\n");
            ds.SapXepTheoLuong();
            Console.Write("\nDanh sach NV sau khi duoc sap xep (Theo bang chu cai)\n");
            ds.SapXepTheoTen();
            ds.TimNVTheoTen();
            Console.Write("\nNhan vien co luong > 2000:\n");
            ds.LuongLonHon2000();
            Console.Write("\nNhan vien co luong lon nhat la:\n");
            Console.Write("MaSo\tTen\t\tLCB\tThem\t\tLuong\n");
            ds.TimLuongLonNhat();
        }
    }
}
