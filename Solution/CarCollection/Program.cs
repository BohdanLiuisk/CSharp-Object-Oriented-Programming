using System;

namespace CarCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Парк машин:");
            var park = new CarCollection<string>();

            park.AddCar("Жигули", new DateTime(1985, 12, 5));
            park.AddCar("Тойота", new DateTime(2000, 4, 7));
            park.AddCar("Форд", new DateTime(2005, 5, 3));
            park.AddCar("Мерседес", new DateTime(2003, 11, 3));

            Console.WriteLine(park.ToString());

            Console.WriteLine("В парке находится: {0} машин", park.Lenght);

            Console.WriteLine("Введите номер интересующей вас машины:");
            string stroka = Console.ReadLine();

            if (string.IsNullOrEmpty(stroka))
                Console.WriteLine("Вы не ввели значение. Поиск не выполнен.");
            else
            {
                int nomer = Convert.ToInt32(stroka);
                Console.WriteLine(park[nomer - 1]);
            }
        }
    }
}