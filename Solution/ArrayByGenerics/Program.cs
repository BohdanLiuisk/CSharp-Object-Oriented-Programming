using System;

namespace ArrayByGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimension of the array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            var arrayList = new ArrayList<int>();

            var rand = new Random();
            for (int i = 0; i < length; i++)
            {
                arrayList.Add(rand.Next(100));
            }

            Console.WriteLine("Array elements: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i] + " ");
  
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Enter a value to search for: ");
            if (arrayList.Contains(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("The entered value is contained in the array.");
            }
            else
            {
                Console.WriteLine("Value not found!");
            }
        }
    }
}
