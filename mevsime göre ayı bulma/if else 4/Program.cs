using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            
            Console.Write("bir mevsim giriniz=");
            mevsim= Convert.ToString(Console.ReadLine());
            


            if (mevsim=="ilkbahar")
            {
                Console.Write("mart,nisan,mayıs");
            }
            else if (mevsim=="kış")
            {
                Console.Write("aralık,ocak,şubat");
            }
            else if (mevsim=="sonbahar")
            {
                Console.Write("eylül,ekim,kasım");
            }
            else 
            {
                Console.Write("haziran,temmuz,ağustos");
            }
            Console.Read();












        }
    }
}
