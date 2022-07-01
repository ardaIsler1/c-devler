using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaç adet string eklemek istersiniz");
            int ekle = Convert.ToInt32(Console.ReadLine());
            string[] elements = new string[ekle];
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine("string ekle");
                elements[i] = Console.ReadLine();
            }
            Console.WriteLine("**********************");
            foreach (string element in elements)
            {
                Console.WriteLine(element);
            }
        Console.ReadLine();
        }
    }
}
