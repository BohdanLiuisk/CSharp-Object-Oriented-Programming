using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = new Train[2];

            UseTrain.AddingAnArray(train);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("You entered the following train information: ");
            Console.WriteLine(new string('-', 50));

            UseTrain.Sort(train);
            UseTrain.Show(train);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Enter train number: ");
            int search = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 50));
            UseTrain.Search(train, search);

            Console.ReadKey();
        }
    }
}
