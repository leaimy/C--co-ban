using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI06_CAULENHDIEUKIEN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            //câu lệnh điều kiện if else
              double diem;
              Console.WriteLine("Mời bạn nhập vào 1 điểm: ");
              diem = double.Parse(Console.ReadLine());
              if(diem>=5)
              {
                  Console.WriteLine("{0} ==> Đậu", diem);
              }
              else
              {
                  Console.WriteLine("Điểm {0} ==> Rớt", diem);
              }
              Console.ReadLine();

            //Toán tử 3 ngôi
            //BÀI1
            double diem1;
            Console.WriteLine("Mời bạn nhập vào 1 điểm: ");
            diem1 = double.Parse(Console.ReadLine());
            string kq = diem1 >= 5 ? "Đậu" : "Rớt";
            Console.WriteLine("Điểm {0} ==> {1}", diem1, kq);
            Console.ReadLine();

            //BÀI2
            /*   double x;
               Console.WriteLine("Mời bạn nhập vào 1 điểm x: ");
               x = double.Parse(Console.ReadLine());
               string ketqua=x>=8&&x<=10?"Giỏi" :( string ketqua = x >= 6.5 && x <8?"Khá" :( string ketqua = x >= 5 && x < 6.5?"Trung bình":"Yếu"));*/

            // Cấu trúc switch
            int a, b;
            char kt;
            Console.WriteLine("Nhập a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phép toán (+,-,*,/):");
            kt = Console.ReadLine()[0];
            switch(kt)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                    break;
            }
            Console.ReadLine();
        }
    }
}
