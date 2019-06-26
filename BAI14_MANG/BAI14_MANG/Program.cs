using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI14_MANG
{
    class Program
    {
        /// <summary>
        /// Tạo một mảng M có n phần tử, sau đó:
        /// 1) Nhập giá trị ngẫu nhiên cho các phần tử trong mảng M
        /// 2) Xuất các giá trị trong mảng 
        /// 3) Đảo ngược mảng 
        /// 4) Sắp xếp mảng 
        /// 5) Tính tổng các phần tử trong mảng
        /// 6) Tìm kiếm mảng
        /// </summary>
        static void Mang_1_Chieu()
        {
            Console.WriteLine("Mời bạn nhập vào số phần tử trong mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] M = new int[n];
            //1. Nhập giá trị ngẫu nhiên:
            Random rd = new Random();
            for (int i = 0; i < M.Length; i++)
                M[i] = rd.Next(100);
            //2. Xuất các giá trị trong mảng:
            Console.WriteLine("Mảng ngẫu nhiên là:");
            for (int i=0;i<M.Length;i++)
            {
                Console.Write(M[i] + "  ");
            }
            //3. Đảo mảng
            Array.Reverse(M);
            Console.WriteLine("\nMảng sau khi đảo chiều là:");
            foreach(int i in M)
            {
                Console.Write(i + "  ");
            }
            //4. Sắp xếp mảng:
            Array.Sort(M);
            Console.WriteLine("\nMảng sau khi sắp xếp là:");
            foreach (int i in M)
            {
                Console.Write(i + "  "); 
            }
            //5. Tính tổng mảng:
            int sum = 0;
            foreach (int x in M)
                sum += x;
            Console.WriteLine("\nTổng mảng là {0}", sum);
            //6. Tìm kiếm mảng: đã sắp xếp mảng 
            Console.WriteLine("Nhập vào số muốn tìm:");
            int k = int.Parse(Console.ReadLine());
            int kq = Array.BinarySearch(M, k);
            if (kq < 0)
                Console.WriteLine("Không tìm thấy {0} trong mảng", k);
            else
                Console.WriteLine("Tìm thấy {0} tại vị trí thứ {1}", k, kq);
        }
        static void TimKiem()
        {
            Console.WriteLine("Mời bạn nhập vào số phần tử trong mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] M = new int[n];
            //1. Nhập giá trị ngẫu nhiên:
            Random rd = new Random();
            for (int i = 0; i < M.Length; i++)
                M[i] = rd.Next(100);
            //2. Xuất các giá trị trong mảng:
            Console.WriteLine("Mảng ngẫu nhiên là:");
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + "  ");
            }
            //3. Tìm kiếm mảng khi chưa sắp xếp (cách 2)
            // Tìm theo tuyến tính
            Console.WriteLine("\nNhập vào số muốn tìm:");
            int k = int.Parse(Console.ReadLine());
            int kq = -1;
            for(int i=0;i<M.Length;i++)
            {
                if(M[i]==k)
                {
                    kq = i;
                    break;
                }            
            }
            if (kq < 0)
                Console.WriteLine("Không tìm thấy {0} trong mảng", k);
            else
                Console.WriteLine("Tìm thấy {0} tại vị trí thứ {1}", k, kq);
        }
        static void Mang_2_Chieu()
        {
            //Nhập mảng 2 chiều
            Console.WriteLine("Nhập số dòng:");
            int dong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số cột:");
            int cot = int.Parse(Console.ReadLine());
            int[,] mang = new int[dong, cot];
            Random rd = new Random();
            for(int i=0;i<mang.GetLength(0);i++)
            {
                for(int j=0;j<mang.GetLength(1);j++)
                {
                    mang[i, j] = rd.Next(100);
                }            
            }
            //Xuất mảng 2 chiều
            Console.WriteLine("Mảng 2 chiều là:");
            for (int i = 0; i < mang.GetLength(0); i++)
            {
                for (int j = 0; j < mang.GetLength(1); j++)
                {
                    Console.Write(mang[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Mang_1_Chieu();
            TimKiem();
            Mang_2_Chieu();
            Console.ReadLine();
        }
    }
}
