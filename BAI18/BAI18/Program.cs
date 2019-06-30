using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien my = new SinhVien();
            my.Ten = "Lệ Ái Mỹ";
            my.Ma = 1115198;
            Console.WriteLine(my);
            string s = my.Ten;
            SinhVien ha = new SinhVien(1812751, "Nguyễn Thị Hà");
            Console.WriteLine(ha);
            Console.ReadLine();
        }
    }
}
