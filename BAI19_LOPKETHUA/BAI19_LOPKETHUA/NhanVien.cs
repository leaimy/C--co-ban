using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI19_LOPKETHUA
{
   public class NhanVien:ILamViec
    {
        public int Ma { get; set; }
        public string Ten { get; set; }

        public string LamViec(string mota)
        {
           string s="Nhân viên đang ["+mota+"]";
            return s;
        }

        public void TinhLuong()
        {
            Console.WriteLine("Đây là phương thức tính lương của NhanVien");
        }
        public virtual int TinhLuong(int ngayCong)
        {
            return ngayCong * 100;
        }
        public virtual int TinhLuong1(int ngayCong)
        {
            return ngayCong * 200;
        }
    }
}
