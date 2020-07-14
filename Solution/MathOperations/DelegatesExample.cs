using System;

namespace MathOperations
{
    delegate double MathOperations(int a, int b);
    delegate double AverageValue(int num1, int num2, int num3);
    class DeletesExample
    {
        public static void DoMathOpearations()
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
            if (operation != null)
                Console.WriteLine("{0:##.###}", operation(a, b));
        }

        public static void FindAverageValue()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Enter first number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int k = Convert.ToInt32(Console.ReadLine());

            AverageValue averageValue = (a, b, c) => (double)(a + b + c) / 3;
            Console.WriteLine("Average value of entered numbers equals {0:##.###}", averageValue(i, j, k));
        }
    }
}
