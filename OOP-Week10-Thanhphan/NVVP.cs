using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week10_Thanhphan
{
    class NVVP:NhanVien
    {
        public double phuCap { get; set; }
        public override double Luong
        {
            get
            {
                return LCB + phuCap;
            }
            set
            {
                Luong = value;
            }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap Phu Cao NV:");
            phuCap = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.Write("{0}\t{1}\t\t{2}\t{3}\t{4}\n", MaSo, Ten, LCB, phuCap, Luong);
        }
    }
}
