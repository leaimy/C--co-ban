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

            foreach(PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }
            NhanVien old = ppt.TimNhanVien(246);
            if(old!=null)
            {
                old.TenNhanVien = "Lê Hoàng Minh Tuệ";
            }

            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty sau khi sửa:");

            foreach (PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }
            if (pNS.XoaNhanVien(1) == false)
            {
                Console.WriteLine("Không tìm thấy mã nhân viên =1 để xóa");
            }
            else
            {
                Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty sau khi xóa:");

                foreach (PhongBan pb in dsPB)
                {
                    Console.WriteLine(pb.TenPhongBan);
                    pb.XuatToanBoNhanVien();
                }
            }
            Console.WriteLine("Danh sách nhân viên thuộc phòng nhân sự:");
            pNS.XuatToanBoNhanVien();
            pNS.SapXep();
            Console.WriteLine("Danh sách nhân viên thuộc phòng nhân sự sau khi sắp xếp:");
            pNS.XuatToanBoNhanVien();
            Console.WriteLine("Danh sách nhân viên thuộc phòng kế toán:");
            pkt.XuatToanBoNhanVien();
            pkt.SapXep();
            Console.WriteLine("Danh sách nhân viên thuộc phòng kế toán sau khi sắp xếp:");
            pkt.XuatToanBoNhanVien();
            Console.WriteLine("Danh sách nhân viên thuộc phòng phát triển:");
            ppt.XuatToanBoNhanVien();
            ppt.SapXep();
            Console.WriteLine("Danh sách nhân viên thuộc phòng phát triển sau khi sắp xếp:");
            ppt.XuatToanBoNhanVien();

            long sum = 0;
            foreach (PhongBan pb in dsPB)
                sum += pb.TongLuong();
            Console.WriteLine("Tổng lương phải thanh toán trong 1 tháng = {0}", sum);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestQLNV();
            Console.ReadLine();
        }
    }
}
