using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "In this chapter, I will introduce information that is fundamental to" +
                                   " working with types and the common language runtime (CLR).";

            Book book = new Book("CLR via C#", "Jeffrey Richter", content);

            book.Show();

            Console.ReadKey();
        }
    }
}
