using Project5.Business;
using Project5.DataAccess;

namespace Project5.ConsoleUI
{
     class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new ProductDal());
            // Interface implement edilen classların adresini tutabildiği için herhangi bir değişiklikte daha önce yazılan koda dokunmadan
            // yeni bir class ekleyip productManager'a parametre olarak verebiliriz.(Sürdürülebilir kod örneği)

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);//UI Katmanı olduğun için burada sadece ekrana nasıl yazılacağını yazıyoruz 
            }
        }
    }
} 