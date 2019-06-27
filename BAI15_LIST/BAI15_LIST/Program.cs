using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI15_LIST
{
    class Program
    {
        static void List()
        {
            // Cấp phát bộ nhớ để sử dụng đối tượng List
            List < string > ds = new List<string>();
            // Thêm một phần tử vào danh sách:
            ds.Add("Mỹ");
            ds.Add("Lệ");
            ds.Add("Ái");
            ds.Add("Nhật");
            ds.Insert(3, "Hạnh Phúc");
            ds.Remove("Nhật");
            ds.RemoveAt(2);
 
            Console.WriteLine("Danh sách các phần tử trong List là:");
            for(int i=0;i<ds.Count;i++)
            {
                string v = ds[i];
                Console.WriteLine(v);
            }
        }
        static void List2()
        {
            List<int> ds = new List<int>();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
                ds.Add(rd.Next(100));
            Console.WriteLine("Các phần tử trong danh sách gốc là:");
            foreach(int x in ds)
            {
                Console.Write(x + "\t");
            }
            ds.Sort();
            Console.WriteLine();
            Console.WriteLine("Các phần tử sau khi sắp xếp:");
            foreach (int x in ds)
                Console.Write(x + "\t");
            int k;
            Console.WriteLine();
            Console.WriteLine("Mời bạn nhập vào số muốn tìm:");
            k = int.Parse(Console.ReadLine());
            int kq = ds.IndexOf(k);
            if (kq < 0)
                Console.WriteLine("Không tìm thấy {0} trong danh sách", k);
            else
                Console.WriteLine("Tìm thấy {0} tại vị trí {1}", k, kq);
        }
          
        static void Main(string[] args)
        {
                Console.OutputEncoding = Encoding.UTF8;
                List();
                List2();
                Console.ReadLine();
            }
        }
    }
