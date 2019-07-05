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
        public NhanVien TimNhanVien(int maNv)
        {
            foreach (NhanVien old in dsNV)
                if (old.MaNhanVien == maNv)
                    return old;
            return null;
        }
        public bool XoaNhanVien(int maNV)
        {
            NhanVien nv = TimNhanVien(maNV);
            if (nv == null) return false;
            dsNV.Remove(nv);
            return true;
        }
        private int compare(NhanVien nv1,NhanVien nv2)
        {
           int kqssTen= string.Compare(nv1.TenNhanVien, nv2.TenNhanVien, true);
            if(kqssTen==0)
            {
                if (nv1.MaNhanVien < nv2.MaNhanVien)
                    return 1;
                if (nv1.MaNhanVien > nv2.MaNhanVien)
                    return -1;
                return 0;
            }
            return kqssTen;
        }
        public void SapXep()
        {
            dsNV.Sort(compare);
        }
        public long  TongLuong()
        {
            long sum = 0;
            foreach (NhanVien nv in dsNV)
                sum += nv.TinhLuong;
            return sum;
        }
    }
}
