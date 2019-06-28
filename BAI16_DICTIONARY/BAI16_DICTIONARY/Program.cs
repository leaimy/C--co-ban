using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI16_DICTIONARY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Ngộ Nhận");
            dic.Add(2, "làm sao để yêu");
            if (dic.ContainsKey(2) == false)
                dic.Add(2, "Đừng yêu nữa em mệt rồi");
            dic.Add(3, "Em ngày xưa khác rồi");
            dic.Add(4, "Rồi người thương cũng hóa người dưng");
            Console.WriteLine("Danh sách bài hát:");
            //để duyệt toàn bộ dữ liệu trong dictionary ta làm như sau:
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("STT:" + item.Key + "; TênBH:" + item.Value);
            }
            dic.Remove(2);
            Console.WriteLine("Danh sách sau khi xóa bài 2:");
            foreach(KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine("STT:" + item.Key + "; TênBH:" + item.Value);
            }
            string value = dic[4];
            Console.WriteLine("Bài hát có STT=4 là " + value);
            // Chuyển đổi Dictionary thành List
            List<string> dsGT = dic.Values.ToList();
            Console.WriteLine("Danh sách tên bài hát:");
            foreach (string v in dsGT)
            {              
                Console.WriteLine(v);
            }
            List<int> dsKey = dic.Keys.ToList();
            Console.WriteLine("Danh sách STT:");
            foreach(int k in dsKey)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}
