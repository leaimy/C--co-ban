using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI05_GHICHU
{
    class Program
    {
        /// <summary>
        /// hàm này dùng để tính xyz
        /// </summary>
        /// <param name="x">nhập x kiểu nguyên</param>
        /// <param name="y">nhập y kiểu nguyên</param>
        static void Ham1(int x, int y)
        {
            Console.WriteLine("Hello World");
        }
        /// <summary>
        /// Đây là hàm tính tổng 3 số
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        static int Tong(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Ham1(4, 5);
            int t = Tong(4, 5, 6);

            //đây là biến a, dùng để lưu giá trị kiểu nguyên
            int a= 5;
            /*
             * Người sửa: Nguyễn Thị Hà
             * Ngày sửa: 18/6/2019
             * Lý do: Bổ sung thêm biến x, khởi tạo x=8 để làm xyz
             */
            x = 8;
            Console.WriteLine("a={0}", a);
        }
    }
}
