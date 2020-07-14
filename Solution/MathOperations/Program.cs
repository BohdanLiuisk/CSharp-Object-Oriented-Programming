using System;

namespace MathOperation
{
    
    delegate int MathOperations(int num1, int num2);
    class Program
    {
        delegate double MathOperations(int a, int b);

        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an operator(+,-,*,/): ");
            string z = Convert.ToString(Console.ReadLine());

            MathOperations operation = null;

            switch (z)
            {
                case "+":
                    operation = (x, y) => { return x + y; };
                    break;
                case "-":
                    operation = (x, y) => { return x - y; };
                    break;
                case "*":
                    operation = (x, y) => { return x * y; };
                    break;
                case "/":
                    operation = (x, y) =>
                    {
                        if (y != 0)
                        {
                            return x / (double)y;
                        }
                        else
                        {
                            Console.WriteLine("Can't divide by zero!");
                            return 0;
                        }
                    };
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.WriteLine(new string('-', 30));
            if (operation != null)
                Console.WriteLine("{0:##.###}", operation(a, b));
        }
    }
}
