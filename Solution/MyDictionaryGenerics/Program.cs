using System;

namespace MyDictionaryGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimension of the dictionary: ");
            int n = Convert.ToInt32(Console.ReadLine());

            var dictionary = new Dictionary<string, string>(n);

            for (int i = 0; i < n; i++)
            {
                string word1 = Console.ReadLine();
                string word2 = Console.ReadLine();
                dictionary.Add(i, word1, word2);
            }

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary.Lenght);
        }
    }
}
