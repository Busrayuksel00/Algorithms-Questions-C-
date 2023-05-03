using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("karenin alanı");
            int birkenar, alan, çevre;
           


           
            



            Console.Write("Bir kenar giriniz=");
            birkenar = Convert.ToInt32(Console.ReadLine());


            alan = (birkenar * birkenar);
            Console.Write("alan=" + alan);
            
            Console.ReadLine();

            çevre = (birkenar + birkenar)  *2;
            Console.Write("çevre=" + çevre);
            Console.ReadLine();



            Console.Read();






        }
    }
}
