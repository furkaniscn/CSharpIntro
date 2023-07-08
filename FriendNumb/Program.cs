using System;

namespace FriendNumb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1 = 220;
            int numb2 = 294;

            bool arkadasSayiMi = ArkadasSayiMi(numb1, numb2);

            if (arkadasSayiMi)
            {
                Console.WriteLine(numb1 + " ve " + numb2 + " arkadaş sayıdır.");
            }
            else
            {
                Console.WriteLine(numb1 + " ve " + numb2 + " arkadaş sayı değildir.");
            }

            static bool ArkadasSayiMi(int numb1, int numb2)
            {
                int toplamBolen1 = ToplamBolenleriBul(numb1);
                int toplamBolen2 = ToplamBolenleriBul(numb2);

                return (numb1 == toplamBolen2) && (numb2 == toplamBolen1);
            }
            static int ToplamBolenleriBul(int numb)
            {
                int toplam = 0;

                for (int i = 1; i <= numb / 2; i++)
                {
                    if (numb % i == 0)
                    {
                        toplam += i;
                    }
                }
                return toplam;
            }
        }
    }
}
   

