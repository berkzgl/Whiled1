using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiled1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayac = 0;

            //while (sayac < 5)
            //{
            //    Console.WriteLine("test");
            //    sayac++;
            //}
            
            int toplam = 0;
            char cvp;

            do
            {
                Console.WriteLine("Sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                toplam += sayi;

                do
                {
                    Console.WriteLine("Devam etmek istiyor musunuz?(E/H)");
                    cvp = char.Parse(Console.ReadLine());
                } while (cvp != 'E' && cvp != 'H');


            } while (cvp == 'E');

            Console.WriteLine($"Sayıların toplamı:{toplam}");

        }
    }
}
//sayı alıp devam etmek istiyormu sordurup tüm sayıları toplama programı