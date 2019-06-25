using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUOI_PHAN2_3
{
    class Program
    {
        //So sánh 2 chuỗi
        //DẠNG 1:
        static void XuLyChuoi1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s,s2;
            Console.WriteLine("Mời bạn nhập vào một chuỗi:");
            s = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập vào chuỗi tiếp theo:");
            s2 = Console.ReadLine();
            int kq = s.CompareTo(s2);
            if(kq==0)
            {
                Console.WriteLine("s và s2 giống nhau");
            }
            else if(kq<0)
            {
                Console.WriteLine("s < s2");
            }
            else
            {
                Console.WriteLine("s > s2");
            }
            Console.ReadLine();
        }
        //DẠNG 2:
        static void XuLyChuoi2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s, s2;
            Console.WriteLine("Mời bạn nhập vào một chuỗi:");
            s = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập vào chuỗi tiếp theo:");
            s2 = Console.ReadLine();
            int kq = s.ToLower().CompareTo(s2.ToLower());
            if (kq == 0)
            {
                Console.WriteLine("s và s2 giống nhau");
            }
            else if (kq < 0)
            {
                Console.WriteLine("s < s2");
            }
            else
            {
                Console.WriteLine("s > s2");
            }
            Console.ReadLine();
        }
        //
        static void XuLyChuoi3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void XuLyChuoi4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "E:/baihat/nhactre/mau nuoc mat.mp3";
            //hãy tìm vị trí đầu tiên của ký tự /
            int vt = s.IndexOf("/");
            Console.WriteLine("Tìm thấy ký tự / ở vị trí thứ {0}", vt);
            //hãy tìm vị trí cuối cùng của ký tự /
            int vt2 = s.LastIndexOf("/");
            Console.WriteLine("Tìm thấy ký tự / ở vị trí thứ {0}", vt2);
            Console.ReadLine();
        }
        
        static void XuLyChuoi5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "E:/baihat/nhactre/mau nuoc mat.mp3";
            //hãy lấy ra tên bài hát có đuôi mp3
            int vt = s.LastIndexOf("/");
            string tenBH = s.Substring(vt + 1);
            Console.WriteLine(tenBH);
            //hãy lấy ra tên bài hát không có đuôi mp3
            string tenBH2 = s.Substring(vt + 1); // hoặc string tenBH2 = s.Substring(vt + 1,12);
            string r = tenBH2.Remove(12, 4); //có nhiều cách lấy
            Console.WriteLine(r);
            Console.ReadLine();
        }
        static void XuLyChuoi6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //tách ra từng phần tử
            string line = "1812751;Lệ Ái Mỹ;AiMy@gmail.com";
            string[] arr = line.Split(';');
            Console.WriteLine("MSSV={0}", arr[0]);
            Console.WriteLine("Tên={0}", arr[1]);
            Console.WriteLine("Email={0}", arr[2]);         
            //gom lại
            string[] mang = new string[3];
            mang[0] = "1812751;";
            mang[1] = "Lệ Ái Mỹ;";
            mang[2] = "AiMy@gmail.com";
            string str = string.Join("", mang);
            Console.WriteLine(str);
            Console.ReadLine();
        }
        //Cho 1 chuỗi gốc, yêu cầu:
        //Xóa các khoảng trắng dư thừa bên trái, phải chuỗi, các từ 
        //cách nhau bởi một khoảng trắng, kí tự đầu tiên viết HOA
        //ví dụ:
        //  LỆ         áI      Mỹ
        //sau khi tối ưu:
        //Lệ Ái Mỹ
        static void ToiUuChuoi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào 1 tên:");
            string ten = Console.ReadLine();
            Console.WriteLine("Chuỗi gốc bạn nhập:");
            Console.WriteLine(ten);
            ten = ten.Trim();//xóa dư thừa bên trái bên phải:

            string[] arr = ten.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ten = "";
            for (int i= 0;i< arr.Length;i++)
            {
                //lấy từng từ ra
                string word = arr[i];
                word = word.ToLower();
                char[] arrWord = word.ToCharArray();
                arrWord[0] = char.ToUpper(arrWord[0]);
                string newWord = new string(arrWord);
                ten += newWord + " ";
            }
            ten = ten.Trim();
            Console.WriteLine("Chuỗi sau khi tối ưu:");
            Console.WriteLine(ten);
            Console.ReadLine();

        }
        
        static void Main(string[] args)
        {
             XuLyChuoi1();
             XuLyChuoi2();
             XuLyChuoi3();
             XuLyChuoi4();
             XuLyChuoi5();
             XuLyChuoi6();
             ToiUuChuoi();
        }
    }
}
