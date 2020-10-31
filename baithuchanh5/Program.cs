using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_thuc_hanh_5
{
    //class TienDien
    //{
    //    protected int scttn, scttt, sddd;
    //    protected string hoten, dchi;
    //    public TienDien()
    //    {
    //        scttn = scttt = 0;
    //        hoten = dchi = "";
    //    }
    //    public TienDien(string hoten, string dchi, int scttn, int scttt)
    //    {
    //        this.scttt = scttt;
    //        this.scttn = scttn;
    //        this.hoten = hoten;
    //        this.dchi = dchi;
    //    }
    //public void Nhap()
    //{
    //    Console.Write("Nhap ho ten chu ho:");
    //    hoten = Consol.eReadLine();
    //    Console.Write("Nhap dia chi:");
    //    dchi = Console.ReadLine();
    //    Console.Write("Nhap so cong to thang nay:");
    //    scttn = int.Parse(Console.ReadLine());
    //    Console.Write("Nhap so cong to thang truoc:");
    //    scttt = int.Parse(Console.ReadLine());
    //}
    //public void Hien()
    //{
    //    Console.Write("Ho ten chu ho:{0}\t Dia chi:{1}\t So cong to thang nay:{2}\t So cong to thang truoc:{3}", hoten, dchi, scttn, scttt);
    //}
    //public double Tinh()
    //    {
    //        return sddd = (scttn - scttt);
    //    }
    //    public double TinhTien()
    //    {
    //        return sddd * 500;
    //    }
    //class TD : TienDien
    //    {
    //        private int dmuc;
    //        public TD(string hoten, string dchi, int scttn, int scttt,int dmuc):base(hoten,dchi,scttn,scttt)
    //        {
    //            this.dmuc = dmuc;
    //        }
    //        public new void Nhap()
    //        {
    //            base.Nhap();
    //            Console.Write("Nhap du lieu dinh muc:");
    //            dmuc = int.Parse(Console.ReadLine());
    ////}
    ////public new void Hien()
    ////{
    ////    base.Hien();
    ////    Console.Write("Du lieu dinh muc", dmuc);
    ////}
    ////public new double TinhC()
    ////{
    ////    if (dmuc > 600)
    ////        return base.TinhTien() * 600;
    ////    else
    ////        base.TinhTien();
    ////}
    //    }
    //    static void Main(string[] args)
    //    {
    //        TienDien A = new TienDien();
    //        A.Nhap();
    //        A.Hien();
    //        Console.Write("Tinh",A.TinhC());
    //        Console.ReadKey();
    //    }
    //}
    //bai 2
    class tamgiac
    {
        private int a, b, c;
        public tamgiac()
        {
            a = b = c = 0;
        }
        public tamgiac(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Nhap()
        {
            Console.Write("Nhap do dai canh a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh c=");
            c = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("Do dai ba canh gom");
            Console.Write("canh a={0}\t canh b={1}\t canh c={2}", a, b, c);
        }
        public double Tinh()
        {
            if (a != b && b != c && c != a)
                Console.Write("Nhap lai");
            else
                return Math.Sqrt(3) / 4 * a * a;
            return Tinh();
        }
        class App
        {
            static void Main(string[] args)
            {
                tamgiac A = new tamgiac();
                A.Nhap();
                A.Hien();
                Console.Write("Tinh:{0}", A.Tinh());
                Console.ReadKey();
            }
        }
    }
}
