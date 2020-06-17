using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(26.7, 29.9, 1);

            converter.ToUsd(1);
            converter.FromUsd(10);

            Console.ReadKey();
        }
    }
}
