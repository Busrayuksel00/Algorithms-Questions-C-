using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;

            Console.WriteLine("bir sayı giriniz=");
            sayı = Convert.ToInt32(Console.ReadLine());

            while (sayı % 2 == 0)
            {
                Console.WriteLine("bir sayı giriniz");
                sayı = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("tek sayı girdiniz");
            Console.Read();










        }
    }
}
