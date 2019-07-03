using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI19_LOPKETHUA
{
   public class HinhVuong:HinhChuNhat
    {
        public HinhVuong(int a):base(a,a)
        {

        }
        public override int DienTich()
        {
            return base.DienTich();
        }
        public override int ChuVi()
        {
            return base.ChuVi();
        }
    }
}
