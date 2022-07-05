using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksyonlar_soru_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList Asalsayılar = new ArrayList();
            ArrayList Asalolmayan = new ArrayList();
         
            for (int b = 0; b < 10; b++)
            {
                Console.WriteLine("sayı giriniz");
                int sayi = int.Parse(Console.ReadLine());
                int sayac = 0;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    Asalsayılar.Add(sayi);
                }
                else
                {
                    Asalolmayan.Add(sayi);
                }
            }
            Asalsayılar.Sort();
            Asalolmayan.Sort();
            Console.WriteLine("*********************");
            Console.WriteLine("asal");
            foreach (int i in Asalsayılar)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("asal olmayan");
            foreach (int i in Asalolmayan)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
