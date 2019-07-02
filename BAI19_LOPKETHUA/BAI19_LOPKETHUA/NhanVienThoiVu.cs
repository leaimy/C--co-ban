using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI19_LOPKETHUA
{
   public class NhanVienThoiVu:NhanVien
    {
        public new void TinhLuong()
        {
            Console.WriteLine("Đây là phương thức tính lương của NhanVienThoiVu");
        }
        public override int TinhLuong1(int ngayCong)
        {
            if (ngayCong >= 7)
                return ngayCong*500;
            return base.TinhLuong1(ngayCong);
        }
    }
}
