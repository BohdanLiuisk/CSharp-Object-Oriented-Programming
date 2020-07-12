using System;

namespace Accountant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of hours worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accountant accountant = new Accountant();

            if (accountant.AskForBonus(Post.Cleaner, hours))
            {
                Console.WriteLine("Give a bonus");
            }
            else
            {
                Console.WriteLine("Do not give out a bonus");
            }
        }
    }
}
