using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;// set çalışır, yazma var
            Console.WriteLine(product.Id);// get çalışır, okuma var
            product.UnitsInStock = 800;
            Console.WriteLine(product.UnitsInStock);
            //product.UnitPrice = 500;
            product.ProductName = "Test";
            Console.WriteLine(product.UnitPrice);
        }
    }

    class Product
    {
        private int myVar;

        public decimal  UnitPrice // propfull
        {
            get { return _unitPrice = _unitPrice*18/100; }
            set { _unitPrice = value; }
        }

        public Product()
        {
            _unitPrice = 500;
        }

        // field
        decimal _unitPrice;

        // Auto implemented property
        public int Id { get; set; }
        public string ProductName { set { ProductName = value; } }
        //public decimal UnitPrice
        //{
            // get { return _unitPrice + _unitPrice * 18 / 100; }// Arkaplanda get ve set böyle çalışıyor. Okur
            //set { _unitPrice = value; }// Yazar
            // readonly örneği yazma işlemi olmadan sadece okuma işlemini böyle yapabiliriz.
       // }

        public decimal UnitsInStock;
    }
}
