using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI12_XULYBIETLE
{
    class Program
    {
        static void PhanSo1(int tu, int mau)
        {
            double phanso = 0;
            // try, catch,finally dùng để phản hồi một trường hợp ngoại lệ làm cho máy đứng giữa chừng khi đang chạy
            //ví dụ: như mẫu bằng 0
            try
            {
                phanso = tu / mau;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            finally
            {
                Console.WriteLine("Ket qua: {0}", phanso);
            }
        }
      




        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập tử số:");
            int tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mẫu số:");
            int mau = int.Parse(Console.ReadLine());
            PhanSo1(tu,mau);
           
            Console.ReadLine();
        }
    }
}
