using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI10_GAMEDOANSO
{
    class Program
    {
        static void Game()
        {
            Console.OutputEncoding = Encoding.UTF8;
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
                if(soLanDoan==7)
                {
                    Console.WriteLine("GAME OVER!@_@ bạn đã đoán quá 7 lần");
                    Console.WriteLine("Số bạn cần đoán là {0}", soCuaMay);
                    break;
                }             
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Game();
            Console.Write("Bạn có muốn chơi tiếp không (có/không):");
            string traloi = Console.ReadLine();
            if(traloi=="co")
            {
                Game();
            }
           
        }
    }
}
