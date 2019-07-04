using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI20_QUANLINHANVIEN
{
   public class PhongBan
    {
        private List<NhanVien> dsNV = new List<NhanVien>();
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public NhanVien TruongPhong { get; set; }
        public bool ThemNhanVien(NhanVien nv)
        {
            bool trungMaNV = false;
            foreach(NhanVien oldNV in dsNV)
                if(oldNV.MaNhanVien==nv.MaNhanVien)
                {
                    trungMaNV = true;
                    break;
                }
            if (trungMaNV == true)
                return false;
            dsNV.Add(nv);
            return true;
        }
        public void XuatToanBoNhanVien()
        {
            foreach(NhanVien nv in dsNV)
            {
                Console.WriteLine(nv);
            }
        }
    }
}
