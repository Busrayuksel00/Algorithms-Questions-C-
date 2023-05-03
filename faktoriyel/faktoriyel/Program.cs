using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("faktorıyeli alınacak sayıyı girin=");
            sayı = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;



            while (sayı > 1)
            {
                faktoriyel = sayı * faktoriyel;
                sayı--;
               
            }

            Console.Write(faktoriyel);
            Console.Read();



        }
    }
}
