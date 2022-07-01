using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilk sayınızı giriniz");
            int deger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayınızı giriniz");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] sayılar = new int[deger];
            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.WriteLine("sayınızı ekleyin");
                int sayıEkle = Convert.ToInt32(Console.ReadLine());
                sayılar[i] = sayıEkle;
            }
            Console.WriteLine("*******n==m ya da n==m*********");
            foreach (var n in sayılar)
            {
                if (n == m || n % m == 0)
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadLine();   

        }
    }
}
