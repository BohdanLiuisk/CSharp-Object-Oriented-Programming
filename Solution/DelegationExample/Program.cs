using System;

namespace DelegationExample
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Search string: " + str);
        }
    }

    static class FindAndReplaceManager
    {
        static public void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
    }

    class Program
    {
        static void Main()
        {
            FindAndReplaceManager.FindNext("Hello");

            // Delay.
            Console.ReadKey();
        }
    }
}
