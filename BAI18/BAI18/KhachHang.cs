using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI18
{
   public class KhachHang //POCO
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public string Phone { get; set; }
        public KhachHang copy()
        {
            return this.MemberwiseClone() as KhachHang;
        }
    }
}
