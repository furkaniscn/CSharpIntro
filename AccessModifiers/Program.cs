using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Id = 1;
            //house.City = "Hatay";
            Console.WriteLine("Hello World!");
        }

        class Customer
        {

        }
    }
}
