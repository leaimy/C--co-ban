using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI09_THUVIEN
{
    class Program
    {
        static void Ten()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ của bạn: ");
            string ho = Console.ReadLine();
            Console.Write("Nhập tên lót và tên của bạn: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Bạn tên là:{0} {1}", ho, ten);
            Console.ReadLine();
        }
        // Hàm toán học
        static void TV_ToanHoc()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào một số a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Căn bậc 2 của {0} = {1}", a, Math.Sqrt(a));  // Tính căn bậc 2
            Console.WriteLine("Nhập vào một số b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Lũy thừa của {0}^{1} = {2}", a, b, Math.Pow(a, b)); // Tính lũy thừa
            Console.ReadLine();
            // Tính lượng giác
            Console.WriteLine("Nhập vào một góc:");
            int goc = int.Parse(Console.ReadLine());
            double radian = Math.PI * goc / 180;
            Console.WriteLine("Sin({0}) = {1}", goc, Math.Sin(radian));
            Console.WriteLine("Cos({0}) = {1}", goc, Math.Cos(radian));
            Console.WriteLine("tan({0}) = {1}", goc, Math.Tan(radian));
            Console.WriteLine("cot({0}) = {1}", goc, 1 / Math.Tan(radian));
            Console.ReadLine();
            // Làm tròn số
            double x = 5.45576786933;
            Console.WriteLine("x ban đầu là: {0}", x);
            Console.WriteLine("x sau khi được làm tròn là: {0}", Math.Round(x, 2));
            Console.ReadLine();
        }
        // Hàm ngẫu nhiên Random
        static void TV_Random()
        {
         Console.OutputEncoding = Encoding.UTF8;
            // Xuất số ngẫu nhiên trong đoạn [0..100]
            Random rd = new Random();
            int x = rd.Next(101);
            Console.WriteLine("Máy ra số ngẫu nhiên [0..100] là {0}", x);
            // Số thực [0..1]
            double y = rd.NextDouble();
            Console.WriteLine("Máy ra số ngẫu nhiên [0..1] là {0}", y);
            // Số thực [0..10]
            Console.WriteLine("Máy ra số ngẫu nhiên [0..10] là {0}", y*10);
            // Số nguyên [50..150]
            int d = rd.Next(50, 150);
            Console.WriteLine("Máy ra số ngẫu nhiên [50..150] là {0}", d);
            Console.ReadLine();
        } 
        // Hàm ngày tháng năm
        static void TV_DateTime()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime n = new DateTime(2000,1,2);
            Console.WriteLine(n.ToString("dd/MM/yyyy"));
            Console.WriteLine(n.ToString("d/M/yyyy"));

            Console.WriteLine("Nhập vào ngày tháng năm sinh của bạn: ");
            string s = Console.ReadLine();
            DateTime birthday = DateTime.Parse(s);
            Console.WriteLine("Ngày sinh của bạn là " + birthday.Day);
            Console.WriteLine("Tháng sinh của bạn là " + birthday.Month);
            Console.WriteLine("Năm sinh của bạn là " + birthday.Year);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            TV_ToanHoc();
            TV_Random();
            TV_DateTime();
            Ten();

        }
    }
}
