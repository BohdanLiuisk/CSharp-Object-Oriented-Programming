using System;

namespace CarCollections
{
    class CarCollection<T>
    {
        private readonly MyList<string> carName;
        private readonly MyList<DateTime> carYear;

        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();
        }

        public void AddCar(string name, DateTime year)
        {
            carName.Add(name);
            carYear.Add(year);
        }

        public string this[int index]
        {
            get
            {
                if (index < carName.Count)
                    return carName[index] + " " + carYear[index];
                return "There are not a car with this index.";
            }
        }

        public int Lenght
        {
            get { return carName.Count; }
        }

        public void Remove()
        {
            carName.Clear();
            carYear.Clear();
        }

        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < carName.Count; i++)
            {
                str += "№" + (i + 1) + " " + carName[i] + " " + carYear[i].Year + "\n";
            }
            if (str != null) 
                return str;
            return "There is not a single car in the park!";
        }
    }
}