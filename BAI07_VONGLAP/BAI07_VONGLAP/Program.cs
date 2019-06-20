using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI07_VONGLAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // TÍNH GIAI THỪA
            // Dùng vòng lặp do..while
            int n;
            int i = 1;
            int giaithua = 1;
            Console.WriteLine("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            do
            {
                giaithua *= i; // giaithua=giaithua*i;
                i++; // i=i+1;
            } while (i <= n);
            Console.WriteLine("{0}! = {1}", n, giaithua);
            Console.ReadLine();
            //Dùng vòng lặp While
            int k;
            int j = 1;
            int gt = 1;
            Console.WriteLine("Nhap vao k:");
            k = int.Parse(Console.ReadLine());
            while (j<=k)
            {
                gt *= j;
                j++;
            }
            Console.WriteLine("{0}! = {1}", k, gt);
            Console.ReadLine();
            //Dùng vòng lặp for
            int m;
            int a;
            int gt1 = 1;
            Console.WriteLine("Nhap vao m:");
            m = int.Parse(Console.ReadLine());
            for(a=1;a<=m;a++)
            {
                gt1 *= a;
            }
            Console.WriteLine("{0}! = {1}", m, gt1);
            Console.ReadLine();
        }
    }
}
