using System;

namespace OpenDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a key: ");
            string key = Console.ReadLine();
            DocumentWorker doc = null;

            switch (key)
            {
                case "prof":
                    doc = new ProDocumentWorker();
                    break;
                case "expert":
                    doc = new ExpertDocumentWorker();
                    break;
                default:
                    Console.WriteLine("Key is wrong.");
                    doc = new DocumentWorker();
                    break;
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}
