﻿using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
        }
    }
}
