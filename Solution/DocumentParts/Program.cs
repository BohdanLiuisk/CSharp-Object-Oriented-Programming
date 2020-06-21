using System;

namespace DocumentParts
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Контракт");
            document.Body = "Тело контракта...";
            document.Footer = "Директор: Иванов И.И.";

            document.Show();

            Console.ReadKey();
        }
    }
}
