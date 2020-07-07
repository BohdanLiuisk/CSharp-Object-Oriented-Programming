using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(9, 71.5));
            Console.WriteLine(Calculator.Subtraction(90, 4.5));
            Console.WriteLine(Calculator.Multiply(10, 20));
            Console.WriteLine(Calculator.Division(10, 0));

            Console.ReadKey();
        }
    }
}
