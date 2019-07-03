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
        static void TestHinhHoc()
        {
            HinhHoc h;
            h = new HinhHoc();
            Console.WriteLine("Diện tích = " + h.TinhDienTich());

            h = new HinhTron();
            Console.WriteLine("Diện tích = " + h.TinhDienTich());
        }
        static void TestHinhChuNhatHinhVuong()
        {
            HinhChuNhat h1 = new HinhChuNhat(4,10);
            Console.WriteLine("Chu vi=" + h1.ChuVi());
            Console.WriteLine("Diện tích=" + h1.DienTich());

            HinhChuNhat h2 = new HinhVuong(7);
            Console.WriteLine("Chu vi=" + h2.ChuVi());
            Console.WriteLine("Diện tích=" + h2.DienTich());

            HinhVuong h3 = new HinhVuong(9);
            Console.WriteLine("Chu vi=" + h3.ChuVi());
            Console.WriteLine("Diện tích=" + h3.DienTich());
        }
        static void TestInterface()
        {
            ILamViec thi = new NhanVien();
            Console.WriteLine(thi.LamViec("Báo cáo kinh doanh"));

            ILamViec my = new SinhVien();
            Console.WriteLine(my.LamViec("Học bài C#"));
        }
        static void TestHocAsVaIs()
        {
            List<ILamViec> ds = new List<ILamViec>();
            NhanVien thi = new NhanVien() { Ma = 1, Ten = "Thi" };
            ds.Add(thi);
            SinhVien my = new SinhVien() { MaSV = "sv1", TenSV = "Mỹ" };
            ds.Add(my);
            ds.Add(new NhanVien() { Ma = 2, Ten = "Lệ" });
            foreach (ILamViec i in ds)
            {
                if (i is NhanVien)
                {
                    NhanVien nv = i as NhanVien;
                    Console.WriteLine("==>Nhân viên " + nv.Ten);
                }
                else if (i is SinhVien)
                {
                    SinhVien sv = i as SinhVien;
                    Console.WriteLine("==>Sinh viên " + sv.TenSV);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestNhanVien();
            TestNhanVien2();
            TestHinhHoc();
            TestHinhChuNhatHinhVuong();
            TestInterface();
            TestHocAsVaIs();
            Console.ReadLine();
        }
    }
}
