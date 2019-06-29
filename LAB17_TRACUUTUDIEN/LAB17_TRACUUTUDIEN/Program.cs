using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB17_TRACUUTUDIEN
{
    class Program
    {
        static Dictionary<string,string> dic = new Dictionary<string,string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();
                Console.WriteLine("Bạn có muốn tiếp tục tra cứu từ điển (c/k)");
                string Chon = Console.ReadLine();
                if (Chon == "k")
                    break;
            }
            Console.WriteLine("BYE! BYE!");
            Console.WriteLine("^_^ SEE YOU AGAIN ^_^");
            Console.ReadLine();
        }

        private static void menu()
        {
            Console.WriteLine("============HỆ THỐNG CHỨC NĂNG=========");
            Console.WriteLine("1. Nhập từ mới vào từ điển");
            Console.WriteLine("2. Sửa từ trong từ điển");
            Console.WriteLine("3. Tra cứu từ điển: Nhập Tiếng Anh để ra Tiếng Việt");
            Console.WriteLine("4. Xóa từ trong từ điển");
            //Console.WriteLine("5. Tra cứu từ đồng nghĩa");
            Console.WriteLine("Bạn chọn chức năng nào?");
            try
            {
                int ChonMenu = int.Parse(Console.ReadLine());
                switch (ChonMenu)
                {
                    case 1:
                        TuMoi();
                        break;
                    case 2:
                        SuaTu();
                        break;
                    case 3:
                        TraTu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                    /*case 5:
                        DongNghia();
                        break;*/
                    default:
                        Console.WriteLine("Bạn chọn lụi chức năng rồi!");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        private static void TuMoi()
        {
            Console.WriteLine("Mời bạn nhập vào từ Tiếng Anh mới:");
            string ta = (Console.ReadLine()).ToLower();
            if(dic.ContainsKey(ta))
            {
                Console.WriteLine("Từ {0} đã tồn tại",ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập vào nghĩa Tiếng Việt:");
                string tv = (Console.ReadLine()).ToLower();
                dic.Add(ta, tv);
            }
        }

        private static void SuaTu()
        {
            Console.WriteLine("Mời bạn nhập từ Tiếng Anh muốn sửa nghĩa:");
            string ta = (Console.ReadLine()).ToLower();
            if(dic.ContainsKey(ta)==false)
            {
                Console.WriteLine("Không tìm thấy [{0}] để sửa", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập lại nghĩa Tiếng Việt:");
                string tv =(Console.ReadLine()).ToLower();
                
                dic[ta] = tv;
            }
        }

        private static void TraTu()
        {
            Console.WriteLine("Mời bạn nhập từ Tiếng Anh cần tra cứu:");
            string ta = (Console.ReadLine()).ToLower();
            if(dic.ContainsKey(ta))
            {
                string tv = dic[ta];
                Console.WriteLine("Nghĩa của [{0}] là {1}", ta, tv);
            }
            else
            {
                Console.WriteLine("Từ điển chưa cập nhật từ [{0}]", ta);
            }
        }

        private static void XoaTu()
        {
            Console.WriteLine("Mời bạn nhập vào từ Tiếng Anh muốn xóa:");
            string ta = (Console.ReadLine()).ToLower();
            if(dic.ContainsKey(ta))
            {
                dic.Remove(ta);
                Console.WriteLine("Xóa thành công từ [{0}]", ta);
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ [{0}] để xóa", ta);
            }
        }

       /* private static void DongNghia()
        {
            throw new NotImplementedException();
        }*/
    }
}
