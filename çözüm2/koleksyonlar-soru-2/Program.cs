using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksyonlar_soru_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("sayı giriniz");
                int n = int.Parse(Console.ReadLine());
                sayilar.Add(n);
            }
            sayilar.Sort();
           
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
            int Ek = sayilar[0] + sayilar[1] + sayilar[2];
            sayilar.Reverse();
            int Eb = sayilar[0] + sayilar[1] + sayilar[2];

            Console.WriteLine("*******SAYILARIN TOPLAMININ ORTALAMASI**********");
            Console.WriteLine("*******(En büyük 3 tane ve En küçük 3 tanenin toplamının ortalaması)**********");
            Console.WriteLine((Ek + Eb) / 2);
            Console.ReadLine();

        }
    }
}
