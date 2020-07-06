using System;

namespace MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray ar = new MyArray(8);

            ar.MinMax();
            ar.Average();
            ar.Odd();

            Console.ReadKey();
        }
    }
}
