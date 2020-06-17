using System;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));

            Console.Write("{0}, \nPerimetr = ", figure.Type);

            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
