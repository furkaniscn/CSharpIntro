using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[]
            { "Ankara", "İstanbul", "İzmir" };
            Console.WriteLine(sehirler.Length);

            sehirler = new string[4];
            sehirler[3] = "Bursa";

            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }

            List<string> sehirler2 = new List<string>() { "Ankara", "İstanbul", "İzmir" };
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Bursa");

            foreach (string s in sehirler2)
            {
                Console.WriteLine(s);
            }

            sehirler2.Add("Adana");
            sehirler2.Remove("İstanbul");
            bool sonuc = sehirler2.Contains("İzmir");
            Console.WriteLine(sonuc);

            

        }
    }
}
