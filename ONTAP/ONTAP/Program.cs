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
            Console.ReadLine();
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
            Console.ReadLine();
        }
        // Ví dụ if else
        static void IfVaElse()
        {
            Console.WriteLine("If..else trong C#:");

            Console.WriteLine("Bạn có muốn nghe một lời chúc vào buổi sáng?");
            Console.WriteLine("Nhập co hoặc khong:");
            string traloi = Console.ReadLine();

            if (traloi == "co")
            {
                Console.WriteLine("Chúc bạn một buổi sáng tốt lành!!!");
                Console.WriteLine("Nhiều niềm vui bạn nhé Smile ^_^");
            }
            else
            {
                Console.WriteLine("Tạm biệt. Hẹn gặp lại -_-");
            }
            Console.WriteLine("----------------------------------");
            Console.ReadLine();
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
            while (num <= 9)
            {
                Console.WriteLine("Cửu chương {0}:", num);
                so_nhan = 1;
                //Vòng lặp do..while
                do
                {

                    Console.WriteLine("{0} x {1} = {2}", num, so_nhan, num * so_nhan);
                    so_nhan++;
                } while (so_nhan <= 10);

                Console.WriteLine("");
                num++;

            }

            Console.WriteLine("----------------------------------");
        }
        // Ví dụ chuỗi
        static void Chuoi()
        {
            Console.WriteLine("Các cách tạo chuỗi trong C#:");

            //C1: Sử dụng phép gán hằng chuỗi và toán tử nối chuỗi 
            string ho, tenlot, ten;
            ho = "Lệ";
            tenlot = "Ái";
            ten = "Mỹ";
            string hovaten = ho + " " + tenlot + " " + ten;
            Console.WriteLine("\nHọ và tên: {0}", hovaten);

            //C2: Sử dụng constructor của lớp string
            char[] chuc = { 'G', 'o', 'o', 'd', 'n', 'i', 'g', 'h', 't' };
            string loichuc = new string(chuc);
            Console.WriteLine("\nChúc ngủ ngon: {0}", loichuc);

            //C3: Từ các phương thức mà trả về một chuỗi
            string[] td = { "Think", "simple", "live", "alone" };
            string thongdiep = string.Join(" ", td);
            Console.WriteLine("\nThông điệp: {0}", thongdiep);

            //C4: Định dạng phương thức để chuyển đổi một giá trị
            DateTime waiting = new DateTime(2019, 7, 10, 21, 47, 5);
            string chat = string.Format("Thông điệp được gửi lúc {0:t} ngay {0:D}", waiting);
            Console.WriteLine("\nThời gian: {0}", chat);
            Console.Write("-----------------------------------------------");
        }
        static void Chuoi1()
        {
            string ch; //Khai báo một chuỗi

            Console.Write("\nNhập và in chuỗi trong C#:\n");
            Console.Write("Nhập một chuỗi: ");
            ch = Console.ReadLine();
            Console.Write("Bạn vừa nhập chuỗi: {0}\n", ch);

            // Tính chiều dài chuỗi
            int chieudai = 0;
            foreach (char kt in ch)
            {
                chieudai += 1;
            }
            Console.WriteLine("Độ dài chuỗi là: {0}", chieudai);

            // Tách chuỗi
            int l = 0;
            Console.Write("In từng ký tự trong chuỗi ban đầu: ");
            while (l <= chieudai - 1) // hoặc "while(l<=ch.Length-1)"
            {
                Console.Write("{0} ", ch[l]);
                l++;
            }
            Console.Write("\n");

            // Tách chuỗi theo chiều đảo ngược
            int d = 0;
            d = chieudai - 1;
            Console.Write("In các ký tự theo chiều đảo ngược: ");
            while (d >= 0)
            {
                Console.Write("{0} ", ch[d]);
                d--;
            }
            Console.Write("\n");

            // Đếm số từ trong một chuỗi
            int cd = 0;
            int dem = 1;
            //lặp đến phần cuối của chuỗi 
            while(cd<=chieudai-1)
            {
                //kiểm tra xem ký tự hiện tại có phải là khoảng trắng
                //hay là ký tự new line hay ký tự tab 
                if(ch[cd]==' '||ch[cd]=='\n'||ch[cd]=='\t')
                {
                    dem++;
                }
                cd++;
            }
            Console.Write("Tổng số từ có trong chuỗi trên là: {0}\n", dem);

            // Đếm số chữ cái, số chữ số, số ký tự đặc biệt của chuỗi
            int chu_cai, chu_so, ky_tu_dac_biet, i;
            chu_cai = chu_so = ky_tu_dac_biet = i = 0;
            //kiểm tra từng ký tự trong chuỗi
            while(i<chieudai)
            {
                if((ch[i]>='a'&&ch[i]<='z')||(ch[i]>='A'&&ch[i]<='Z'))
                {
                    chu_cai++;
                }
                else if(ch[i]>='0'&&ch[i]<='9')
                {
                    chu_so++;
                }
                else
                {
                    ky_tu_dac_biet++;
                }
                i++;
            }
            Console.Write("Số chữ cái trong chuỗi là: {0}\n", chu_cai);
            Console.Write("Số chữ số trong chuỗi là: {0}\n", chu_so);
            Console.Write("Số ký tự đặc biệt trong chuỗi là: {0}\n", ky_tu_dac_biet);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bien();
            Hang();
            IfVaElse();
            VongLap();
            Chuoi();
            Chuoi1();
            Console.ReadLine();
        }
    
    }
}
