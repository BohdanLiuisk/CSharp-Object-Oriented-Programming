using System;

namespace ExtensionMyList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimension of the array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            var list = new MyList<int>(length);

            var rand = new Random();
            for (int i = 0; i < length; i++)
            {
                list.Add(i, rand.Next(100));
            }

            Console.WriteLine("Array ");
            int[] f = list.GetArray();   // use of the extension method

            for (int i = 0; i < f.Length; i++)
            {
                Console.Write("{0} ", f[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Длинна массива: {0}", list.Length);
        }
    }
}
