using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sınav1, sınav2, ortalama;
            
            Console.Write("sınav notunuzu giriniz=");
            sınav1= Convert.ToDouble(Console.ReadLine());

            Console.Write("sınav notunuzu giriniz=");
            sınav2 = Convert.ToDouble(Console.ReadLine());

            ortalama = (sınav1 + sınav2) / 2;
            if (ortalama > 60)
            {
                Console.Write("geçtiniz");
            }
            else
            {
                Console.Write("kaldınız");
            }
            Console.Read();
        












        }
    }
}
