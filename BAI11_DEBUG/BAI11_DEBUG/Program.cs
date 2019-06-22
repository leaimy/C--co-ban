using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI11_DEBUG
{
    class Program
    {
        static string GiaiPhuongTrinhBac2(int a,int b,int c)
        {
            // ax^2+bx+c=0
            if(a==0)
            {
                if (b == 0 && c == 0)
                    return "Phương trình vô số nghiệm";
                if (b == 0 && c != 0)
                    return "Phương trình vô nghiệm";
                return "x=" + (-c*1.0 / b);
            }
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                    return "Vô nghiệm";
                if(delta==0)
                {
                    double x = -b / 2 * a;
                    return "Phương trình có nghiệm kép x= " + x;
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    return "Phương trình có 2 nghiệm p/b x1="+x1 +"; x2=" + x2;
                }              
            }      
        }
        static void NgayThangNam()
        {
            Console.WriteLine("Nhập vào ngày tháng năm sinh của bạn: ");
            string s = Console.ReadLine();
            DateTime birthday = DateTime.Parse(s);         
            Console.WriteLine("Ngày sinh của bạn là " + birthday.Day);
            Console.WriteLine("Tháng sinh của bạn là " + birthday.Month);
            Console.WriteLine("Năm sinh của bạn là " + birthday.Year);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            String kq = GiaiPhuongTrinhBac2(0, 0, 0);
            Console.WriteLine(kq);
            kq = GiaiPhuongTrinhBac2(0, 0, 5);
            Console.WriteLine(kq);
            //0x^2+8x+4=0
            //x=-4/8=-1/2=-0.5
            kq = GiaiPhuongTrinhBac2(0, 8, 4);
            Console.WriteLine(kq);
            //2x^2+5x-7=0
            //delta=5*5-4*2*(-7)=81>0 có 2 nghiệm
            kq = GiaiPhuongTrinhBac2(2, 5, -7);
            Console.WriteLine(kq);
            NgayThangNam();
            Console.ReadLine();
        }
    }
}
