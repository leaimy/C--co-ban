using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI18
{
   public class SinhVien
    {
        #region các biến lớp
        private int ma;
        private string ten;
        #endregion
        #region các constructor
        public SinhVien()
        {
            this.ma = 1;
            this.ten = "Tên gì đó";
        }
        public SinhVien(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
        #endregion
        #region các Properties
        public int Ma
        {
            get
            {
                return this.ma;
            }
            set
            {
                this.ma = value;
            }
        }
        public string Ten
        {
            set
            {
                this.ten = value;
            }
            get
            {
                return this.ten;
            }
        }
        #endregion
        #region các phương thức
        public override string ToString()
        {
            return this.ma+"\t"+this.ten;
        }
        #endregion
    }
}
