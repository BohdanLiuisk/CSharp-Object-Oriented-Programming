using System;

namespace Address
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateObject();

            Console.ReadKey();
        }

        static void CreateObject()
        {
            Address address = new Address();

            address.Country = "Ukraine";
            address.City = "Kiev";
            address.Street = "Khreshchatyk Street";
            address.House = "29B";
            address.Apartment = "4";
            address.Index = "603850";

            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
            Console.WriteLine(address.Index);
        }
    }
}