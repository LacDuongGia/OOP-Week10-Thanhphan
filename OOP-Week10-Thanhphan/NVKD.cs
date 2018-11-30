using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week10_Thanhphan
{
    class NVKD : NhanVien
    {
        public double HoaHong { get; set; }
        public override double Luong
        {
            get
            {
                return LCB + HoaHong;
            }
            set
            {
                Luong = value;
            }
        }
        public NVKD() : base()
        {
            HoaHong = 0;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap Hoa Hong duoc nhan:");
            HoaHong = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.Write("{0}\t{1}\t\t{2}\t{3}\t{4}\n", MaSo, Ten, LCB, HoaHong, Luong);
        }
    }
}
