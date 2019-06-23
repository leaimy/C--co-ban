using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI10_GAMEDOANSO
{
    class Program
    {
        static void Game1()
        {
            Random rd = new Random();
            int soCuaMay = rd.Next(501); //số ngẫu nhiên [0..500]
            int soCuaNguoi;
            int soLanDoan = 0;
            Console.WriteLine("Máy đã ra 1 số [0..500], mời bạn đoán");
            while(true)
            {
                soCuaNguoi = int.Parse(Console.ReadLine());
                soLanDoan++;
                Console.WriteLine("Số lần đoán của bạn là {0}", soLanDoan);
                if (soCuaNguoi==soCuaMay)
                {
                    Console.WriteLine("Chúc mừng bạn, bạn đã đoán đúng ^_^");
                    break;
                }
                if(soCuaNguoi>soCuaMay)
                {
                    Console.WriteLine("Số bạn đoán > Số của máy");
                }
                else
                {
                    Console.WriteLine("Số bạn đoán < Số của máy");
                }
                if(soLanDoan==8)
                {
                    Console.WriteLine("GAME OVER!@_@ bạn đã đoán quá 8 lần");
                    Console.WriteLine("Số bạn cần đoán là {0}", soCuaMay);
                    break;
                }             
            }
            Console.ReadLine();
        }
        static void Game2()
        {
            Random rd = new Random();
            int soCuaMay = rd.Next(501); //số ngẫu nhiên [0..500]
            int soCuaNguoi;
            int soLanDoan = 0;
            Console.WriteLine("Máy đã ra 1 số [0..500], mời bạn đoán");
            while (true)
            {
                soCuaNguoi = int.Parse(Console.ReadLine());
                soLanDoan++;
                Console.WriteLine("Số lần đoán của bạn là {0}", soLanDoan);
                if (soCuaNguoi == soCuaMay)
                {
                    Console.WriteLine("Chúc mừng bạn, bạn đã đoán đúng ^_^");
                    break;
                }
                if (soCuaNguoi > soCuaMay)
                {
                    Console.WriteLine("Số bạn đoán > Số của máy");
                }
                else
                {
                    Console.WriteLine("Số bạn đoán < Số của máy");
                }
                if (soLanDoan == 7)
                {
                    Console.WriteLine("GAME OVER!@_@ bạn đã đoán quá 7 lần");
                    Console.WriteLine("Số bạn cần đoán là {0}", soCuaMay);
                    break;
                }
            }
            Console.ReadLine();
        }
        static void Game3()
        {
            Random rd = new Random();
            int soCuaMay = rd.Next(501); //số ngẫu nhiên [0..500]
            int soCuaNguoi;
            int soLanDoan = 0;
            Console.WriteLine("Máy đã ra 1 số [0..500], mời bạn đoán");
            while (true)
            {
                soCuaNguoi = int.Parse(Console.ReadLine());
                soLanDoan++;
                Console.WriteLine("Số lần đoán của bạn là {0}", soLanDoan);
                if (soCuaNguoi == soCuaMay)
                {
                    Console.WriteLine("Chúc mừng bạn, bạn đã đoán đúng ^_^");
                    break;
                }
                if (soCuaNguoi > soCuaMay)
                {
                    Console.WriteLine("Số bạn đoán > Số của máy");
                }
                else
                {
                    Console.WriteLine("Số bạn đoán < Số của máy");
                }
                if (soLanDoan == 6)
                {
                    Console.WriteLine("GAME OVER!@_@ bạn đã đoán quá 6 lần");
                    Console.WriteLine("Số bạn cần đoán là {0}", soCuaMay);
                    break;
                }
            }
            Console.ReadLine();
        }
        static void cd()
        {
            while (true)
            {
                Console.WriteLine("Mời bạn chọn cấp độ (dễ,trung bình,khó):");
                string capdo = Console.ReadLine();
                if (capdo == "de")
                {
                    Game1();
                    break;
                }
                if (capdo == "trung binh")
                {
                    Game2();
                    break;
                }
                if (capdo == "kho")
                {
                    Game3();
                    break;
                }

            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            cd();
            while (true)
            {
                Console.Write("Bạn có muốn chơi tiếp không (có/không):");
                string traloi = Console.ReadLine();
                if (traloi == "co")
                {
                    cd();
                }
                if(traloi=="khong")
                {
                    break;
                }
            }
           
        }
    }
}
