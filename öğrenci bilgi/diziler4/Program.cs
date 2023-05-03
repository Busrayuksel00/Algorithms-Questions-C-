using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isim = new string[2];
            string[] soyisim = new string[2];
            double[] sınav1 = new double[2];
            double[] sınav2 = new double[2];
            double[] ortalama = new double[2];
            for(int i = 0; i < 2; i++)
            {
                Console.Clear();

                Console.Write((i+1)+ "Öğrencinin Adı=");
                isim[i] = Console.ReadLine();

                Console.Write((i + 1) + "Öğrenci Soyadı=");
                soyisim[i] = Console.ReadLine();

                Console.Write((i + 1) + "sınav1 notu=");
                sınav1[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write((i + 1) + "sınav2notu=");
                sınav2[i] = Convert.ToDouble(Console.ReadLine());

                ortalama[i] = (sınav1[i] + sınav2[i])/2;





            }
            Console.WriteLine("öğrenciAdı=       öğrenciSoyadı=        sınav1        sınav2       ortalama "  );
            Console.WriteLine();
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("      " + isim[i] + "     " + soyisim[i] + "         " + sınav1[i] + "       " + sınav2[i]+ "     " + ortalama[i]); 
            }
            Console.Read();







        }
    }
}
