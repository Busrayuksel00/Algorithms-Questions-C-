using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("bir sayı giriniz=");
            sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı>0)
            {
                Console.Write("pozitif");
            }
            else
            {
                Console.Write("negatif");
            }

            Console.Read();







        }
    }
}
