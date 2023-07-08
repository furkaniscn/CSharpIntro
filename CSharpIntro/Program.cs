using System;

namespace CSharpIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double piyasDun = 63.2;
            double piyasBugun = 63;
            bool A = piyasBugun == piyasDun;
            string piyasaArtis = " Artıyor";
            string piyasaAzalis = " Azalıyor";
            string piyasaSabit = " Piyasa Sabit";

            if(piyasBugun>piyasDun)
            {
                Console.WriteLine(piyasBugun + piyasaArtis);
            }
            else if(piyasDun>piyasBugun) 
            {
                Console.WriteLine(piyasDun + piyasaAzalis);
            }
            else
            {
                Console.WriteLine(piyasaSabit);
            }
        }
    }
}
