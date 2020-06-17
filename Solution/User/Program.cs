﻿using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateUser();

            Console.ReadKey();
        }

        static void CreateUser()
        {
            User user = new User();
            Console.WriteLine(user.date.ToString());
            Console.WriteLine(user.Familyname);

            user.Familyname = "Evans";
            Console.WriteLine(user.Familyname);

            Console.WriteLine(new string('-', 30));

            User user2 = new User("naya", "Ann", "Kolesnik", 20);
            Console.WriteLine(user2.date.ToString());
            Console.WriteLine(user2.Familyname);
        }
    }
}
