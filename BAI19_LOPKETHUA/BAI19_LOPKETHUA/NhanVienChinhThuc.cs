using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI19_LOPKETHUA
{
   public class NhanVienChinhThuc:NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Đây là phương thức tính lương của NhanVienChinhThuc");
        }
        public override int TinhLuong(int ngayCong)
        {
            if (ngayCong == 20)
                return 10000000;
            return base.TinhLuong(ngayCong);
        }

    }
}
