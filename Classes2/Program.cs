using System;

namespace Classes2
{
    internal class Program
    {
        //instance
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                ProductName = "Test", UnitPrice = 500, UnitInStock = 600
            };

            //product.ProductName = "Ürün İsmi";
            //Console.WriteLine(product.ProductName);

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            
        }
    }
}
