using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] krediler = new string[7];
            krediler[0] = "Hızlı Kredi";
            krediler[1] = "Özel Kredi";
            krediler[2] = "Yavaş Kredi";
            krediler[3] = "Çapraz Kredi";
            krediler[4] = "Anti Kredi";
            krediler[5] = "Titiz Kredi";
            krediler[6] = "Temiz Kredi";

            for (int i = 0; i < krediler.Length; i++)
            {
                Console.WriteLine(krediler[i]);
            }
            Console.WriteLine("----------------For bitti------------------");
            foreach (string s in krediler)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("---------------Foreach bitti---------------------");

            int sayac = 0;
            while (sayac < krediler.Length) 
            {
                Console.WriteLine(krediler[sayac]); 
                sayac++;
            }
            Console.WriteLine("-------------While bitti--------------");

            int sayac2 = 0;
            do
            {
                Console.WriteLine(krediler[sayac2]);
                sayac2++;
            } while (sayac2 < krediler.Length);
        }
    }
}
