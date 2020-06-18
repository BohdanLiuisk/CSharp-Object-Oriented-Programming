using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter print = new ColorPrinter(ConsoleColor.Yellow);
            print.Print("Hello");

            Printer printUp = print;
            printUp.Print("Hello");

            ColorPrinter printDown = (ColorPrinter)printUp;
            printDown.Print("Hello");

            new ColorPrinter(ConsoleColor.Red).Print("New Hello");

            Printer new_print = new Printer(ConsoleColor.Green);
            new_print.Print("Green color");

            Console.ReadKey();
        }
    }
}
