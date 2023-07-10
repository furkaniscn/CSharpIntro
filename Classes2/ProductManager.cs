using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    //methods
    //reusability
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi \n" + product.ProductName + " " + product.UnitPrice + " " + product.UnitInStock);
        }
    }
}
