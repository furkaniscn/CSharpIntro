namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            Console.WriteLine(matematik.Bol(3, 0));
        }
    }

    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public decimal Bol(int sayi1, int sayi2)
        {
            try
            {
                return sayi1 / sayi2;
            }
            catch (DivideByZeroException)// Öngrülen hataları yazabiliriz
            { 

                Console.WriteLine("0' a bölme hatası");
                throw new DivideByZeroException("Sıfıra bölünemez.");
            }
            catch (DllNotFoundException)// Öngrülen hataları yazabiliriz
            {
                Console.WriteLine("DLL Hatası gibi gibi gibi...");
                throw new DllNotFoundException();
            }
            catch (Exception excepton)// Öngörülemeyen bir hata için ise direkt olarak Exception kullanırız
            {
                Console.WriteLine("Hiç öngörülmeyen bir hata oluştu...");
                Console.WriteLine(excepton.InnerException);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally çalıştı.");
            }
        }
    }
}