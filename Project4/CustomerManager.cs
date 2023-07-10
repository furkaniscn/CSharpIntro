using Project4;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project4
{
   
    internal class CustomerManager
    {
        public CustomerManager()// newlendiğinde constructor çalışır.
        {
            customers = new List<Customer>()
            {
                new Customer {Id=1,FirstName="Engin",LastName="Ot",City="Ankara",Email="ankara@.com"},
                new Customer {Id=2,FirstName="Derin",LastName="Demir",City="Hatay",Email="hatay@.com"},
                new Customer {Id=3,FirstName="Ahmet",LastName="Yılmaz",City="Adana",Email="adana@.com"},
                new Customer {Id=4,FirstName="Mehmet",LastName="Yıldır",City="Mersin",Email="mersin@.com"},
                new Customer {Id=5,FirstName="Furkan",LastName="İşcan",City="İstanbul",Email="istanbul@.com"}
            };// Önce yapıcı blok çalışır.
        }


        List<Customer> customers;
        public List<Customer> GetAll()
        {

            //Veritabanına bağlan
            
            return customers;
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}

