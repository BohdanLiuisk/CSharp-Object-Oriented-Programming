using System;

namespace Dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Словарь:");

            var dictionary = new Dictionary<string, string>();

            dictionary.AddToDictionary("table", "стол");
            dictionary.AddToDictionary("apple", "яблоко");
            dictionary.AddToDictionary("sun", "солнце");
            dictionary.AddToDictionary("pencil", "карандаш");
            dictionary.AddToDictionary("cap", "чашка");
            dictionary.AddToDictionary("tea", "чай");

            Console.WriteLine(dictionary.ToString());
            Console.WriteLine();

            Console.WriteLine("В словаре {0} записей", dictionary.Length);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите номер записи в словаре:");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                Console.WriteLine("Вы не ввели номер записи в словаре");
            else
            {
                int number = Convert.ToInt32(str);
                Console.WriteLine(dictionary[number - 1]);
            }

            Console.WriteLine("Введите значение для поиска");
            string p = Console.ReadLine();
            Console.WriteLine(dictionary[p]);
        }
    }
}