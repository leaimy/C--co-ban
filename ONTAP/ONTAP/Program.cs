using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP
{
    class Program
    {
        // Ví dụ biến
        static void Bien()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Khai báo và khởi tạo biến trong C#:");
            

            // Khai báo biến
            short a;
            int b;
            double c;

            //Khởi tạo biến
            a = 11;
            b = 15;
            c = a + b;
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            Console.WriteLine("----------------------------------");
           
        }
        // Ví dụ hằng
        static void Hang()
        {
            Console.WriteLine("Hằng số trong C#:");

            //Khai báo hằng số pi
            const double pi = 3.14;

            double r;
            Console.WriteLine("Nhập bán kính:");
            r = double.Parse(Console.ReadLine());
            double dien_tich = pi * r * r;
            Console.WriteLine("Bán kính: {0}, Diện tích: {1}", r, dien_tich);
            Console.WriteLine("----------------------------------");
        }
        // Ví dụ if else
        static void IfVaElse()
        {
            Console.WriteLine("If..else trong C#:");

            Console.WriteLine("Bạn có muốn nghe một lời chúc vào buổi sáng?");
            Console.WriteLine("Nhập co hoặc khong:");
            string traloi = Console.ReadLine();
       
                if(traloi=="co")
                {
                    Console.WriteLine("Chúc bạn một buổi sáng tốt lành!!!");
                    Console.WriteLine("Nhiều niềm vui bạn nhé Smile ^_^");
                }
                else
                {
                Console.WriteLine("Tạm biệt. Hẹn gặp lại -_-");
                }
            Console.WriteLine("----------------------------------");
        }
        // Ví dụ vòng lặp
        static void VongLap()
        {
            //In bảng cửu chương
            // While
            Console.WriteLine("In bảng cửu chương trong C#:");
            Console.WriteLine("");
            int num, so_nhan;
            num = 2;
            while(num<=9)
            {
                Console.WriteLine("Cửu chương {0}:", num);
                so_nhan = 1;

                while(so_nhan<=10)
                {
                    
                    Console.WriteLine("{0} x {1} = {2}", num, so_nhan, num * so_nhan);
                    so_nhan++;
                }
                
                Console.WriteLine("");
                num++;
                
            }

            Console.Write("----------------------------------");
        }
    
    
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bien();
            Hang();
            IfVaElse();
            VongLap();

            Console.ReadLine();
        }
    }
}
