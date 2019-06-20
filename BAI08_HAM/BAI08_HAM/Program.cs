using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI08_HAM
{
    class Program
    {
        // BÀI 1: Tính giai thừa
        static int TinhGiaiThua(int n)
        {
            int giaiThua = 1;
            for (int i = 1; i <= n; i++)
                giaiThua *= i;
            return giaiThua;
        }
        //BÀI 2: Giải phương trình bậc nhất
          //Cách 1: Dùng hàm string
        static string GiaiPhuongTrinhBacNhat(double a1,double b1)
        {
            if (a1 == 0 && b1 == 0)
                return "Phương trình vô số nghiệm";
            if (a1 == 0 && b1 != 0)
                return "Phương trình vô nghiệm";
            return "x="+(-b1 / a1);
        }
          // Cách 2: Dùng hàm void
          static void Giai_PT_Bac1(double e,double d)
        {
            
            if(e==0&&d==0)
            {
                Console.WriteLine("Phương trình vô số nghiệm");
            }
            else
            {
                if (e == 0 && d != 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
                else
                    Console.WriteLine("x={0}", -d / e);
            }          
        }

        //TÌM HIỂU VỀ THAM TRỊ THAM BIẾN:
          //Tham trị: Không thay đổi giá trị khi đi qua hàm
          static void fn(int m)
        {
            m = m + 4;
            Console.WriteLine("Giá trị m trong hàm là {0}",m);
        }
          //Tham biến hay còn gọi là tham chiếu: Thay đổi giá trị khi đi qua hàm
          //Cách 1: Dùng lệnh ref
          static void fn1(ref int h)
        {
            h = h * 2;
            Console.WriteLine("Giá trị h trong hàm là {0}", h);
        }
        //Cách 2: Dùng lệnh out
        static void fn2(out int k)
        {
            k = 2;
            Console.WriteLine("Giá trị k trong hàm là {0}", k);
        }

        // BÀI 3: GIẢI PHƯƠNG TRÌNH BẬC 2
        static void GiaiPhuongTrinhBac2(float a,float b,float c)
        {
            
            if (a == 0)
                if(b==0)
                    if(c==0)           
                Console.WriteLine("Phương trình vô số nghiệm");
            else
                        Console.WriteLine("Phương trình vô nghiệm");
            else
                    Console.WriteLine("x={0}", -c / b);
            else
            {
                Console.WriteLine("Phương trình dạng bậc 2");
                    float delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                    else
                        if (delta == 0)
                    {
                        Console.WriteLine("Phương trình có nghiệm kép x={0}", -b / (2 * a));
                    }
                    else
                    {
                        if (delta > 0)
                        {
                        float x1, x2;
                        x1 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("Phương trình có 2 nghiệm x1={0} ; x2={1}", x1, x2);
                    }
                    }
                }
            }
   
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n:");
            int n = int.Parse(Console.ReadLine());
            int kq=TinhGiaiThua(n);
             Console.WriteLine("{0}! ={1}", n, kq);
             Console.ReadLine();

             Console.WriteLine("Nhập a1:");
             double a1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Nhập b1:");
             double b1 = double.Parse(Console.ReadLine());
             string kq1 = GiaiPhuongTrinhBacNhat(a1, b1);
             Console.WriteLine(kq1);
             Console.ReadLine();

             Console.WriteLine("Nhập e:");
             double e = double.Parse(Console.ReadLine());
             Console.WriteLine("Nhập d:");
             double d = double.Parse(Console.ReadLine());
               Giai_PT_Bac1(e, d);
             Console.ReadLine();

            int m = 5;
            Console.WriteLine("Giá trị m trước khi gọi hàm fn là {0}", m);
            fn(m);
            Console.WriteLine("Giá trị m sau khi gọi hàm fn là {0}", m);
            Console.ReadLine();

            int h = 10;
            Console.WriteLine("Giá trị h trước khi gọi hàm fn1 là {0}", h);
            fn1(ref h);
            Console.WriteLine("Giá trị h sau khi gọi hàm fn1 là {0}", h);
            Console.ReadLine();

            int k = 12;
            Console.WriteLine("Giá trị k trước khi gọi hàm fn2 là {0}", k);
            fn2(out k);
            Console.WriteLine("Giá trị k sau khi gọi hàm fn2 là {0}", k);
            Console.ReadLine();

            Console.WriteLine("Nhập a:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập c:");
            float c = float.Parse(Console.ReadLine());
            GiaiPhuongTrinhBac2( a, b, c);
            Console.ReadLine();
        }
    }
}
