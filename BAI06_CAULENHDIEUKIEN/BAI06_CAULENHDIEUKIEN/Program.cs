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
            //cách 1: if else
              double x;
               Console.WriteLine("Mời bạn nhập vào 1 điểm x: ");
               x = double.Parse(Console.ReadLine());
            if (x >= 8 && x <= 10)
            {
                Console.WriteLine("x={0}==> Giỏi", x);
            }
            else
            {
                if (x >= 6.5 && x < 8)
                {
                    Console.WriteLine("x={0}==> Khá", x);
                }
                else
                {
                    if (x >= 5 && x < 6.5)
                    {
                        Console.WriteLine("x={0}==> Trung bình", x);
                    }
                    else
                        Console.WriteLine("x={0}==> Yếu", x);
                }
            }
                Console.ReadLine();

            //cách 2: toán tử ba ngôi
           double x1;
            Console.WriteLine("Mời bạn nhập vào 1 điểm x1: ");
            x1 = double.Parse(Console.ReadLine());
            if (x1 <= 10 && x1 >= 0)
            {
                String ketqua = (x1 <= 10 && x1 >= 8) ? "Giỏi" : (x1 >= 6.5 ? "Khá" : (x1 >= 5 ? "Trung bình" : "Yếu"));
                Console.WriteLine("Điểm {0}==> {1}", x1, ketqua);
            }
            else
                Console.WriteLine("Điểm x1 chỉ ở trong khoảng từ [0...10] thôi");
            Console.ReadLine();

            // Cấu trúc switch
            // BÀI 1:
             int a;
            int b;
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

            //BÀI 2:
            //Nhập vào một tháng hỏi tháng đó có bao nhiêu ngày, nếu là tháng 2 thì yêu cầu nhập năm để kiểm tra năm nhuần, 
            //năm nhuần tháng 2 có 29 ngày, không nhuần thì có 28 ngày.
            //tháng 1,3,5,7,8,10,12 có 31 ngày
            //tháng 4,6,9,11 có 30 ngày
            int thang, songay=0;
            Console.WriteLine("Mời bạn nhập vào 1 tháng: ");
            thang = int.Parse(Console.ReadLine());
            if (thang >= 1 && thang <= 12)
            {
                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        songay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        songay = 30;
                        break;
                    case 2:
                        Console.WriteLine("Nhập năm:");
                        int nam = int.Parse(Console.ReadLine());
                        if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0) //Năm nhuần
                            songay = 29;
                        else
                            songay = 28;
                        break;
                }
                Console.Write("Tháng {0} có số ngày là: {1}", thang, songay);
            }
            else
                Console.WriteLine("Số tháng không hợp lệ");

            Console.ReadLine();
        }
    }
}
