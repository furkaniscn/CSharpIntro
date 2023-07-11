using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Furkan", LastName = "İŞCAN", City = "Hatay" };
            Customer customer2 = new Customer(2, "Ahmet", "İŞCAN", "Hatay");
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer1.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
