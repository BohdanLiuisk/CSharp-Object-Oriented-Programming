using System;

namespace Store
{
    class Article
    {
        double price;

        public string Name { get; private set; }
        public string Shop { get; set; }

        public double Price
        {
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Cost cannot be negative");
            }
            get { return price; }
        }

        public Article(string name)
        {
            Name = name;
        }

        public Article(string name, string shop, double price)
        {
            Name = name;
            Shop = shop;
            Price = price;
        }

        public string Info()
        {
            return string.Format("Cost of a {0} from {1}: {2} UAN.", Name, Shop, Price);
        }
    }
}
