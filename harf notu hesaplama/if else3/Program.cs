using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sınav1, sınav2, ortalama;
            Console.Write("sınav notunuzu giriniz=");
            sınav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("sınav notunuzu giriniz=");
            sınav2 = Convert.ToInt32(Console.ReadLine());

            ortalama = (sınav1 + sınav2) / 2;
            Console.Write("ortalamanız="+ortalama);
            
            Console.ReadLine();

            if (ortalama >= 60 && ortalama < 66)
            {
                Console.Write("cc geçtiniz");
            }
            else if (ortalama >= 67 && ortalama < 73)
            {


                Console.Write("cb ile geçtiniz");
            }

            else if (ortalama >= 74 && ortalama < 80)
            {
                Console.Write("bb ile geçtiniz");
            }
            else if (ortalama >= 81 && ortalama < 87)
            {
                Console.Write("ba ile geçtiniz");
            }
            else if (ortalama >= 88 && ortalama < 100)
            {
                Console.Write("aa ile geçtiniz");
            }
            else if (ortalama >= 53 && ortalama < 59)
            {
                Console.Write("dc ile kaldınız");
            }
            else if (ortalama >= 46 && ortalama < 52) { 
                Console.Write("dd ile kaldınız");
            }
            else if (ortalama >= 39 && ortalama < 45) { 
                Console.Write("fd ile kaldınız");
            }

            else
            {
                Console.WriteLine("ff ile kaldınız");
            }

            Console.Read();






        }
    }
}
