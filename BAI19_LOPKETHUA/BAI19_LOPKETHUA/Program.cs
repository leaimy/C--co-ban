using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI19_LOPKETHUA
{
    class Program
    {
        static void TestNhanVien()
        {
            NhanVienChinhThuc my = new NhanVienChinhThuc();
            my.Ma = 1;
            my.Ten = "Lệ Ái Mỹ";
            Console.WriteLine("Lương của "+my.Ten+" = ");
            my.TinhLuong();

            NhanVienThoiVu anh = new NhanVienThoiVu();
            anh.Ma = 2;
            anh.Ten = "Tú Anh";
            Console.WriteLine("Lương của " + anh.Ten + " = ");
            anh.TinhLuong();
        }
        static void TestNhanVien2()
        {
            NhanVienChinhThuc my = new NhanVienChinhThuc();
            int luong = my.TinhLuong(20);
            Console.WriteLine("Lương của Mỹ=" + luong);
            NhanVienChinhThuc anh = new NhanVienChinhThuc();
            int luong1 = anh.TinhLuong(18);
            Console.WriteLine("Lương của Anh=" + luong1);

            NhanVienThoiVu hoa = new NhanVienThoiVu();
            int luong2 = hoa.TinhLuong1(8);
            Console.WriteLine("Lương của Hoa=" + luong2);
            NhanVienThoiVu mich = new NhanVienThoiVu();
            int luong3 = mich.TinhLuong1(2);
            Console.WriteLine("Lương của Mịch=" + luong3);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestNhanVien();
            TestNhanVien2();
            Console.ReadLine();
        }
    }
}
