using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime birthday;
            TimeSpan wait;

            Console.WriteLine("Enter your date of birth in the format 'yyyy, mm, dd': ");
            birthday = Convert.ToDateTime(Console.ReadLine());


            DateTime thisYear = new DateTime(now.Year, birthday.Month, birthday.Day);

            if (thisYear < now)
            {
                thisYear = new DateTime(now.Year + 1, birthday.Month, birthday.Day);
                wait = thisYear - now;
            }
            else
            {
                wait = thisYear - now;
            }

            Console.WriteLine("There are {0} days left before your birthday.", wait.Days);

        }
    }
}
