using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week10_Thanhphan
{
    class NhanVien
    {
        public int MaSo { get; set; }
        public string Ten { get; set; }
        public double LCB { get; set; }
        public virtual double Luong { get; set; }
        public NhanVien()
        {
            MaSo = 0;
            Ten = "";
            LCB = 0;
        }
        public NhanVien(int ms, string t, double lcb)
        {
            MaSo = ms;
            Ten = t;
            LCB = lcb;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap MaSo NV:");
            MaSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ten NV:");
            Ten = Console.ReadLine();
            Console.Write("Nhap Luong Co Ban NV:");
            LCB = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write("{0}\t{1}\t{2}\n", MaSo, Ten, LCB);
        }
        public string CatTen()
        {
            string[] arrWord = Ten.Split(' ');
            int N = arrWord.Length;
            return arrWord[N - 1];
        }
    }
}
