using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first rectangle side: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second rectangle side: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Perimeter = {0}, Area = {1}", rectangle.Perimeter, rectangle.Area);

            Console.ReadKey();
        }
    }
}
