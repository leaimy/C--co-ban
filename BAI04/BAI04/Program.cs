using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI04
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.OutputEncoding = Encoding.UTF8;
              int a = 5;
              a += 2; //tuong duong a=a+2
              Console.WriteLine("a = {0}", a);
              Console.ReadLine();

              //Nhap vao 1 so, hoi so nay chan hay le
              int b;
              Console.WriteLine("Moi ban nhap vao so b: ");
              b = int.Parse(Console.ReadLine());
              //Console.Readline() ==> cho nguoi dung nhap 1 gia tri roi nhan Enter
              //Neu nhap 5 ==> hieu la "5" ==> can dua "5" ve 5
              // ==> int.Parse("5") dung chuyen doi kieu du lieu
              if (b % 2 == 0)
                  Console.WriteLine("{0} la so chan", b);
              else
                  Console.WriteLine("{0} la so le", b);

              int year;
              Console.WriteLine("Moi ban nhap vao 1 nam: ");
              year = int.Parse(Console.ReadLine());
              //Nam nhuan la nam chia het cho 4 nhung khong chia het cho 100
              // hoac chia het cho 400
              if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
              {
                  Console.WriteLine("{0} la nam nhuan", year);
              }
              else
              {
                  Console.WriteLine("{0} khong phai nam nhuan", year);
              }
              double diem;
              Console.WriteLine("Moi ban nhap vao 1 diem: ");
              diem = double.Parse(Console.ReadLine());
              if (!(diem>5))
              {
                  Console.WriteLine("diem == {0}==> rot", diem);
              }
              else
              {
                  Console.WriteLine("diem ={0}==> dau", diem);
              }

              Console.ReadLine();

            int a = 5, b = 8, c = 9;
            int z = ++a - --b + c++ - 2;
            Console.WriteLine("a={0},b={1},c={2},z={3}", a, b, c, z);
            Console.ReadLine();
            
            int a1 = 5, b1 = 8, c1 = 9;
            int z1 = ++a1 - b1++ - --c1 + 2;
            Console.WriteLine("a1={0},b1={1},c1={2},z1={3}", a1, b1, c1, z1);
            Console.ReadLine();
            
            
        }
    }
}
