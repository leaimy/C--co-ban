using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI12_CHUOI
{
    class Program
    {
        //^-^ CHUỖI PHẦN MỘT ^_^ 
        //Nhập vào một chuỗi, sau đó:
        //Đếm xem chuỗi có bao nhiêu chữ in hoa, in thường, số, khoảng trắng
        //Cách 1: Dùng mảng
        static void DemChuoi1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "";
            Console.WriteLine("Nhập chuỗi cần đếm:");
            s = Console.ReadLine();
            int demInHoa = 0, demInThuong = 0, demSo = 0, demKT = 0;
            char[] arr = s.ToCharArray();
            for(int i=0;i<arr.Length;i++)
            {
                if (char.IsUpper(arr[i]))
                    demInHoa++;
                if (char.IsLower(arr[i]))
                    demInThuong++;
                if (char.IsDigit(arr[i]))
                    demSo++;
                if (char.IsWhiteSpace(arr[i]))
                    demKT++;
            }
            Console.WriteLine("Có {0} ký tự in hoa", demInHoa);
            Console.WriteLine("Có {0} ký tự in thường", demInThuong);
            Console.WriteLine("Có {0} ký tự số", demSo);
            Console.WriteLine("Có {0} ký tự khoảng trắng", demKT);
            Console.ReadLine();
        }
        //Cách 2: 
        static void DemChuoi2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "";
            Console.WriteLine("Nhập chuỗi cần đếm:");
            s = Console.ReadLine();
            int demInHoa = 0, demInThuong = 0, demSo = 0, demKT = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char kt = s[i]; //Lấy ký tự thứ i ra
                if (char.IsUpper(kt))
                    demInHoa++;
                if (char.IsLower(kt))
                    demInThuong++;
                if (char.IsDigit(kt))
                    demSo++;
                if (char.IsWhiteSpace(kt))
                    demKT++;
            }
            Console.WriteLine("Có {0} ký tự in hoa", demInHoa);
            Console.WriteLine("Có {0} ký tự in thường", demInThuong);
            Console.WriteLine("Có {0} ký tự số", demSo);
            Console.WriteLine("Có {0} ký tự khoảng trắng", demKT);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            DemChuoi1();
            DemChuoi2();
        }
    }
}
