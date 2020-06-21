using System;


namespace AbstractHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor = new Redactor();
            redactor.ChooseDocument("file.doc");

            redactor.Open();
            redactor.Change();
            redactor.Save();

            Console.ReadKey();
        }
    }
}
