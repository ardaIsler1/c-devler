using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaç tane sayı eklemek istersiniz");
            int sayılar = Convert.ToInt32(Console.ReadLine());
            
            int[] SayıDizisi = new int[sayılar];
            for (int i = 0; i < SayıDizisi.Length; i++)
            {
                Console.WriteLine("sayınızı ekleyin");
                int sayıEkle = Convert.ToInt32(Console.ReadLine());
                SayıDizisi[i] = sayıEkle;
            }
            Console.WriteLine("*******ÇİFT SAYILAR*******");
            foreach (var sayı in SayıDizisi)
            {
                if (sayı % 2 == 0)
                {
                    Console.WriteLine(sayı);
                }
            }
            
            Console.ReadLine();
        }
    }
}
