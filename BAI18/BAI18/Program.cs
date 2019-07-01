using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI18
{
    class Program
    {
        static void TestLop()
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien my = new SinhVien();
            my.Ten = "Lệ Ái Mỹ";
            my.Ma = 1115198;
            Console.WriteLine(my);
            string s = my.Ten;
            SinhVien ha = new SinhVien(1812751, "Nguyễn Thị Hà");
            Console.WriteLine(ha);

            SinhVien an = new SinhVien();
            an.Ma = 2;
            an.Ten = "Nguyễn Bình An";
            an.NamSinh = new DateTime(1998, 1, 1);
            an.XuatThongTin();
            SinhVien ai = new SinhVien();
            ai.Ma = 3;
            ai.Ten = "Nguyễn Ái";
            ai.NamSinh = new DateTime(2012, 1, 1);
            ai.XuatThongTin();
            Console.ReadLine();
        }
        static void TestParams()
        {
            ClassTestParam test = new ClassTestParam();
            Console.WriteLine(test.Sum(1, 2, 3, 4, 5, 6, 7, 8));
            Console.WriteLine(test.Sum());
            Console.WriteLine(test.Sum(-3,-5,690));
        }
        static void TestKhachHang()
        {
            List<KhachHang> dsKH = new List<KhachHang>();
            dsKH.Add(new KhachHang() { Ma = 1, Ten = "Mỹ Diên", Phone = "01673856" });
            KhachHang anh = new KhachHang();
            anh.Ma = 4;
            anh.Ten = "Tú Anh";
            anh.Phone = "098457435";
            dsKH.Add(anh);
            dsKH.Add(new KhachHang()
            {
                Ma = 2,
                Ten = "Dương Mịch",
                Phone = "01756690"
            }
            );
            foreach(KhachHang kh in dsKH)
            {
                Console.WriteLine(kh.Ma + "\t" + kh.Ten + "\t" + kh.Phone);
            }
        }
        static void TestAliasVaGomRac()
        {
            KhachHang ha = new KhachHang() { Ma = 5, Ten = "Hà", Phone = "07048576" };
            KhachHang phuong = new KhachHang() { Ma = 7, Ten = "Phương", Phone = "07475669" };
            ha = phuong;
            Console.WriteLine("Tên của Hà là [{0}]", ha.Ten);
            //như vậy lúc này ô nhớ mà hà đang trỏ trước lúc gán ha=phuong bị thu hồi
            //và lúc này ô nhớ phương đang trỏ có thêm tèo trỏ vào nữa
            //==> hà hoặc phương đổi thì cũng làm cho cả hà và phương đổi:
            ha.Ten = "OBAMA";
            Console.WriteLine("Tên của Phương là [{0}]", phuong.Ten);

            KhachHang an = new KhachHang() { Ma = 3, Ten = "An" };
            KhachHang binh = an.copy();
            //Lúc này theo MemberwiseClone thì nó sao chép toàn bộ thông tin của an 
            //ra 1 ô nhớ mới hoàn toàn độc lập, ô nhớ này do bình quản lý 
            //==> an và bình quản lý 2 ô nhớ hoàn toàn khác nhau 
            //==> an đổi chẳng ảnh hưởng gì đến bình và ngược lại
            binh.Ten = "BÌNH BÌNH BÌNH";
            Console.WriteLine("Tên của An là [{0}]", an.Ten);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestLop();
            TestParams();
            TestKhachHang();
            TestAliasVaGomRac();
            Console.ReadLine();
        }
    }
}
