using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev4
{
    public class Program
    {
        static void Main(string[] args)
        {
        
            string metin;
            Console.Write("Metni Girin  : ");
            metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            Console.ReadKey();
        
        }
    }
}
