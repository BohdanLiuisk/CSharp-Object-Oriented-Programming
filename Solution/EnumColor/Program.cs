using System;

namespace EnumColor
{
    enum Colors
    {
        Blue = 0,
        Red = 1,
        Green = 2
    }
    static class PrintColor
    {
        public static void Print(string line, int color)
        {
            switch (color)
            {
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("The line you entered will be displayed in the default color!");
                    break;
            }

            Console.WriteLine(line);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string line = Console.ReadLine();

            Console.WriteLine("Specify the color (0-blue, 2-green, 1-red): ");
            int color = Convert.ToInt32(Console.ReadLine());

            PrintColor.Print(line, color);
        }
    }
}
