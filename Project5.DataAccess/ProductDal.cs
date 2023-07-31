using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    public class ProductDal : IProductDal
    {
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>()
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Acer",
                    QuantityPerUnit = "8 gb",
                    UnitPrice = 10000,
                    UnitsInStock = 29,
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Asus",
                    QuantityPerUnit = "16 gb",
                    UnitPrice = 15000,
                    UnitsInStock = 18,
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Casper",
                    QuantityPerUnit = "16 gb",
                    UnitPrice = 20000,
                    UnitsInStock = 33,
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "MSI",
                    QuantityPerUnit = "32 gb",
                    UnitPrice = 30000,
                    UnitsInStock = 11,
                }
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado .NET ile Eklendi.");
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
