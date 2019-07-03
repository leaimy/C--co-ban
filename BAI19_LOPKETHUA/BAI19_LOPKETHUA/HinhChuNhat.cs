using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI19_LOPKETHUA
{
   public class HinhChuNhat
    {
        public int CanhA { get; set; }
        public int CanhB { get; set; }
        public HinhChuNhat(int canhA,int canhB)
        {
            CanhA = canhA;
            CanhB = canhB;
        }
        public virtual int DienTich()
        {
            return CanhA * CanhB;
        }
        public virtual int ChuVi()
        {
            return (CanhA + CanhB) * 2;
        }
    }
}
