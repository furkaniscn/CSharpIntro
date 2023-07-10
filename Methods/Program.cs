using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            int sonuc1 = matematik.Topla(2, 3);
            int sonuc2 = matematik.Topla(2, 65, 68);
            int sonuc3 = matematik.Topla(sayi2: 65, sayi1: 10);
            matematik.Topla(1, 2);
            int sonuc4 = matematik.ToplaParams(new int[] { 2, 3, 4, 5, 6 });
            int sonuc5 = matematik.ToplaParams(2, 3, 4, 5, 6);
            Console.WriteLine(sonuc5);
            Console.WriteLine(sonuc2);
            int sonuc6 = matematik.Cikar(2, 3);
            Console.WriteLine(sonuc6);
        }
    }

    class Matematik
    {
        // İki tane aynı isimde method olabilir 
        // parametreleri farklı olmak zorunda(Overloading)
        public int Topla(int sayi1, int sayi2)
        {
            //int toplam = sayi1 + sayi2;
            return sayi1 + sayi2;
        }
        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            //int toplam = sayi1 + sayi2;
            return sayi1 + sayi2 + sayi3;
        }

        public int ToplaParams(params int[] sayilar)
        {
            int sonuc = 0;
            //foreach (var sayi in sayilar)
            //{
            //    sonuc += sayi;
            //}

            return sayilar.Sum();
        }

        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
