using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write((i + 1).ToString() + ".sayıyı girin=");
                sayılar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enbüyük;
            enbüyük = sayılar[0];

            for(int i = 1; i < 5; i++)
            {
                if (enbüyük <sayılar[i])
                {
                    enbüyük = sayılar[i];
                }
            }
            Console.WriteLine("en büyük sayı="+enbüyük);
            Console.ReadLine();













        }
    }
}
