using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Not sistemi");
            double sınav1, sınav2, proje, ortalama;



            Console.Write("sınav1 notunuzu giriniz= ");
            sınav1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("sınav2 notunuzu giriniz=");
            sınav2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("proje notunuzu giriniz=");
            proje = Convert.ToDouble(Console.ReadLine());

            ortalama = (sınav1 + sınav2 + proje)/3;
            Console.Write("ortalama=" + ortalama);
            ortalama = Convert.ToDouble(Console.ReadLine());

            Console.Read();
            




























        }
    }
}
