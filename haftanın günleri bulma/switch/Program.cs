using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;


            Console.Write("1 ile 7 arasında rakam  giriniz=");

            sayı = Convert.ToInt32(Console.ReadLine());
            
            

            switch (sayı)
            {
                case 1:
                    Console.Write("pazartesi");
                    break;
            }
            switch (sayı)
            {
                case 2:
                    Console.Write("salı");
                    break;
            }
            switch (sayı)
            {
                case 3:
                    Console.Write("çarşamba");
                    break;
            }
            switch (sayı)
            {
                case 4:
                    Console.Write("perşembe");
                    break;
            }
            switch (sayı)
            {
                case 5:
                    Console.Write("cuma");
                    break;
            }
            switch (sayı)
            {
                case 6:
                    Console.Write("cumartesi");
                    break;
            }
            switch (sayı)
            {
                case 7:
                    Console.Write("pazar");
                    break;
            }
            Console.Read();







        }
    }
}
