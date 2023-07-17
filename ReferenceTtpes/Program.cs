using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10; int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("Sayı 1: " + sayi1);


            //int[] sayilar1 = new int[] { 1,2,3};
            //int[] sayilar2 = new int[] { 10,20,30};

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar 1 = " + sayilar1[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Furkan";
            person2 = person1;
            person1.FirstName = "Veysel";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Veyso";
            customer.CreditCardNumber = "132731";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;// Inheritance olduğu için BASE classtan atama yapabiliriz, BASE class olduğu için diğer classların adresini tutabilir.
            customer.FirstName = "Ahmet";
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);// Boxing

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

        }
    }

    class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }
    
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)// Hem customer'a hem employee'e erişim sağladık bu sayede
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
