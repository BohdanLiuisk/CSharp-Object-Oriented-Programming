﻿using System;

namespace NotebookStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.Show();

            Notebook notebook2 = new Notebook("TT-45", "DELL", 570.99);
            notebook2.Show();

            Notebook notebook3 = new Notebook("RR-34");
            notebook3.Show();

            Console.ReadKey();
        }
    }
}
