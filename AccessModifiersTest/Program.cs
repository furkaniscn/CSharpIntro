using AccessModifiers;
using System;

namespace AccessModifiersTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();// public ile using'e ekledik
            Console.WriteLine("Hello World!");
        }
    }
}
