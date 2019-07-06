using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_BAI20
{
    class Program
    {
        static List<PhongBan> dsPB = new List<PhongBan>();
        

        static void XuatNV()
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

            NhanVien n = new NhanVien();
            n.MaNhanVien = 357;
            n.TenNhanVien = "Nguyễn Thành Nam";
            n.ChucVu = LoaiChucVu.NHAN_VIEN;
            pNS.ThemNhanVien(n);

            PhongBan pkt = new PhongBan();
            pkt.MaPhongBan = 2;
            pkt.TenPhongBan = "Phòng kế toán";
            dsPB.Add(pkt);
            NhanVien hoa = new NhanVien();
            hoa.MaNhanVien = 789;
            hoa.TenNhanVien = "Nguyễn Hoa";
            hoa.ChucVu = LoaiChucVu.PHO_PHONG;
            pkt.ThemNhanVien(hoa);
            NhanVien thao = new NhanVien();
            thao.MaNhanVien = 555;
            thao.TenNhanVien = "Châu lệ Thảo";
            thao.ChucVu = LoaiChucVu.NHAN_VIEN;
            pkt.ThemNhanVien(thao);

            PhongBan ppt = new PhongBan();
            ppt.MaPhongBan = 3;
            ppt.TenPhongBan = "Phòng phát triển";
            dsPB.Add(ppt);
            NhanVien quoc = new NhanVien();
            quoc.MaNhanVien = 246;
            quoc.TenNhanVien = "Lê Minh Quốc";
            quoc.ChucVu = LoaiChucVu.NHAN_VIEN;
            ppt.ThemNhanVien(quoc);
            NhanVien anh = new NhanVien();
            anh.MaNhanVien = 876;
            anh.TenNhanVien = "Bùi Tú Anh";
            anh.ChucVu = LoaiChucVu.TRUONG_PHONG;
            ppt.ThemNhanVien(anh);

            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty:");

            foreach (PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }
        }
        static void SuaNV()
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

            NhanVien n = new NhanVien();
            n.MaNhanVien = 357;
            n.TenNhanVien = "Nguyễn Thành Nam";
            n.ChucVu = LoaiChucVu.NHAN_VIEN;
            pNS.ThemNhanVien(n);

            PhongBan pkt = new PhongBan();
            pkt.MaPhongBan = 2;
            pkt.TenPhongBan = "Phòng kế toán";
            dsPB.Add(pkt);
            NhanVien hoa = new NhanVien();
            hoa.MaNhanVien = 789;
            hoa.TenNhanVien = "Nguyễn Hoa";
            hoa.ChucVu = LoaiChucVu.PHO_PHONG;
            pkt.ThemNhanVien(hoa);
            NhanVien thao = new NhanVien();
            thao.MaNhanVien = 555;
            thao.TenNhanVien = "Châu lệ Thảo";
            thao.ChucVu = LoaiChucVu.NHAN_VIEN;
            pkt.ThemNhanVien(thao);

            PhongBan ppt = new PhongBan();
            ppt.MaPhongBan = 3;
            ppt.TenPhongBan = "Phòng phát triển";
            dsPB.Add(ppt);
            NhanVien quoc = new NhanVien();
            quoc.MaNhanVien = 246;
            quoc.TenNhanVien = "Lê Minh Quốc";
            quoc.ChucVu = LoaiChucVu.NHAN_VIEN;
            ppt.ThemNhanVien(quoc);
            NhanVien anh = new NhanVien();
            anh.MaNhanVien = 876;
            anh.TenNhanVien = "Bùi Tú Anh";
            anh.ChucVu = LoaiChucVu.TRUONG_PHONG;
            ppt.ThemNhanVien(anh);

            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty:");

            foreach (PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }
           
            NhanVien old =pNS.TimNhanVien(123);
            if (old != null)
            {

                old.TenNhanVien = "Nguyễn Minh Tuệ";
            }

            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty sau khi sửa:");

            foreach (PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }
        }

        

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Menu();
                Console.WriteLine("Bạn có muốn tiếp tục (c/k):");
                string traloi = Console.ReadLine();
                if (traloi == "k")
                    break;
            }
            Console.ReadLine();
        }
        static void Menu()
        {
            Console.WriteLine("===========HỆ THỐNG CHỨC NĂNG===========");
            Console.WriteLine("1. Xuất nhân viên");
            Console.WriteLine("2. Sửa nhân viên");
            Console.WriteLine("3. Xóa nhân viên");
            Console.WriteLine("4. Sắp xếp nhân viên");
            Console.WriteLine("5. Tìm nhân viên");
            Console.WriteLine("6. Tổng số lương phải trả trong 1 tháng");
            Console.WriteLine("Chọn chức năng [1..6] là:");
            int chonMenu = int.Parse(Console.ReadLine());
            switch(chonMenu)
            {
                case 1:
                    Console.WriteLine("1. Xuất nhân viên");
                    XuatNV();
                    break;
                case 2:
                    Console.WriteLine("2. Sửa nhân viên");
                    SuaNV();
                    break;
                case 3:
                    Console.WriteLine("3. Xóa nhân viên");
                    break;
                case 4:
                    Console.WriteLine("4. Sắp xếp nhân viên");
                    break;
                case 5:
                    Console.WriteLine("5. Tìm nhân viên");
                    break;
                case 6:
                    Console.WriteLine("6. Tổng số lương phải trả trong 1 tháng");
                    break;
            }
        }
    }
}
