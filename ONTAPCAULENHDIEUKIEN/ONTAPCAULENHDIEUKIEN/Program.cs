using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAPCAULENHDIEUKIEN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //BÀI 1: Tìm kết quả đậu rớt
            // Cách 1: Dùng if else
            double diem;
            Console.Write("Nhập vào 1 điểm: ");
            diem = double.Parse(Console.ReadLine());
            if(diem>=5)
            {
                Console.WriteLine("Điểm {0} ==> Đậu",diem);
            }
            else
            {
                Console.WriteLine("Điểm {0} ==> Rớt",diem);
            }
            // Cách 2: Dùng toán tử 3 ngôi
            double diem1;
            Console.Write("Nhập vào 1 điểm: ");
            diem1 = double.Parse(Console.ReadLine());
            string kq = diem1 >= 5 ? "Đậu" : "Rớt";
            Console.WriteLine("Điểm {0} ==> {1}", diem1,kq);
            Console.ReadLine();

            //BÀI 2: Xuất thông báo xếp loại
            //[8..10] -> Giỏi
            //[6.5..8) -> Khá
            //[5..6.5) -> Trung bình
            //[0..5) -> Yếu
            //Cách 1: Dùng if else
            double x;
            Console.Write("Nhập vào 1 điểm để xếp loại: ");
            x = double.Parse(Console.ReadLine());
            if(x>=8&&x<=10)
            {
                Console.WriteLine("Điểm x={0} xếp loại Giỏi ");
            }
            else
            {
                if (x >= 6.5 && x < 8)
                {
                    Console.WriteLine("Điểm x={0} xếp loại Khá");
                }
                else
                {
                    if (x >= 5 && x < 6.5)
                    {
                        Console.WriteLine("Điểm x={0} xếp loại Trung bình");
                    }
                    else

                        Console.WriteLine("Điểm x={0} xếp loại Yếu");
                }               
                }
            // Cách 2: Dùng toán tử 3 ngôi
            double x1;
            Console.Write("Nhập vào 1 điểm để xếp loại: ");
            x1 = double.Parse(Console.ReadLine());
            if (x1 <= 10 && x1 >= 0)
            {
                String ketqua = x1 >= 8 ? "Giỏi" : (x1 >= 6.5 ? "Khá" : (x1 >= 5 ? "Trung bình" : "Yếu"));
                Console.WriteLine("Điểm x1={0} xếp loại {1}", x1, ketqua);
            }
            else
            {
                Console.WriteLine("Điểm không hợp lệ");
            }
            Console.ReadLine();
             
            //BÀI 3: Cho a, b là 2 số nguyên, kt là 1 ký tự nhập từ bàn phím (+,-,*,/).
            //Nếu nhập kt là phép toán nào thì tự động tính toán cho a,b.
            // Cách 1:Dùng if else
            int a, b;
            char kt;
            Console.WriteLine("Nhập a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phép toán (+,-,*,/): ");
            kt = Console.ReadLine()[0];
            if (kt=='+')
            {
                Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            }
            else
            {
                if (kt=='-')
                {
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                }
                else
                {
                    if (kt=='*')
                    {
                        Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    }
                    else

                        Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                }
            }
            // Cách 2: Dùng Switch
            int c, d;
            char kt1;
            Console.WriteLine("Nhập c: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập d: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phép toán (+,-,*,/): ");
            kt1 = Console.ReadLine()[0];
            switch(kt1)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", c, d, c + d);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", c, d, c - d);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", c, d, c * d);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", c, d, c / d);
                    break;
            }
            Console.ReadLine();

            //BÀI 4: Nhập vào 1 tháng hỏi tháng đó có bao nhiêu ngày,
                   //Nếu là tháng 2 thì yêu cầu nhập năm để kiểm tra năm nhuần, năm nhuần tháng 2 có 29 ngày, không nhuần thì có 28 ngày.
                   //tháng 1,3,5,7,8,10,12 có 31 ngày
                   //tháng 4,6,9,11 có 30 ngày
            // Dùng Switch
            int thang;
            int songay = 0;
            int nam;
            Console.WriteLine("Nhập tháng: ");
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
                        nam = int.Parse(Console.ReadLine());
                        if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                        {
                            songay = 29;
                        }
                        else
                        {
                            songay = 28;
                        }
                        break;
                }
                Console.WriteLine("Số ngày của tháng {0} là {1}", thang, songay);
            }
            else
            {
                Console.WriteLine("Tháng không hợp lệ");
            }
            Console.ReadLine();
        }
    }
}
