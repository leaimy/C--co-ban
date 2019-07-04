using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI20_QUANLINHANVIEN
{
    class Program
    {
        static List<PhongBan> dsPB = new List<PhongBan>();
        static void TestQLNV()
        {
            PhongBan pNS = new PhongBan();
            pNS.MaPhongBan = 1;
            pNS.TenPhongBan = "Phòng nhân sự";
            dsPB.Add(pNS);

            NhanVien nam = new NhanVien();
            nam.MaNhanVien = 123;
            nam.TenNhanVien = "Nguyễn Thành Nam";
            nam.ChucVu = LoaiChucVu.NHAN_VIEN;
            pNS.ThemNhanVien(nam);

            NhanVien nu = new NhanVien();
            nu.MaNhanVien = 456;
            nu.TenNhanVien = "Lê Thị Mỹ Nữ";
            nu.ChucVu = LoaiChucVu.TRUONG_PHONG;
            pNS.ThemNhanVien(nu);

            PhongBan pkt = new PhongBan();
            pkt.MaPhongBan = 2;
            pkt.TenPhongBan = "Phòng kế toán";
            dsPB.Add(pkt);
            NhanVien hoa = new NhanVien();
            hoa.MaNhanVien = 789;
            hoa.TenNhanVien = "Nguyễn Hoa";
            hoa.ChucVu = LoaiChucVu.PHO_PHONG;
            pkt.ThemNhanVien(hoa);

            PhongBan ppt = new PhongBan();
            ppt.MaPhongBan = 3;
            ppt.TenPhongBan = "Phòng phát triển";
            dsPB.Add(ppt);
            NhanVien quoc = new NhanVien();
            quoc.MaNhanVien = 246;
            quoc.TenNhanVien = "Lê Minh Quốc";
            quoc.ChucVu = LoaiChucVu.NHAN_VIEN;
            ppt.ThemNhanVien(quoc);

            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty:");

            foreach(PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestQLNV();
            Console.ReadLine();
        }
    }
}
