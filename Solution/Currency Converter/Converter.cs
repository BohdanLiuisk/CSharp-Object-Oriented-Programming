using System;

namespace Currency_Converter
{
    class Converter
    {
        double usd, eur, uan;

        public Converter(double usd, double eur, double uan)
        {
            this.usd = usd;
            this.eur = eur;
            this.uan = uan;
        }

        public void ToUsd(double uahSum)
        {
            Console.WriteLine(uahSum / usd);
        }

        public void FromUsd(double usdSum)
        {
            Console.WriteLine(usdSum * usd);
        }

        public void ToEur(double uahSum)
        {
            Console.WriteLine(uahSum / eur);
        }

        public void FromEur(double eurSum)
        {
            Console.WriteLine(eurSum * usd);
        }

        public void ToUan(double uahSum)
        {
            Console.WriteLine(uahSum / uan);
        }

        public void FromUan(double rubSum)
        {
            Console.WriteLine(rubSum * usd);
        }
    }
}
