using System;

namespace Train
{
    public struct Train
    {
        private string destination;
        private int number;
        private DateTime time;

        public Train(string destination, int number, DateTime time)
        {
            this.destination = destination;
            this.number = number;
            this.time = time;
        }

        public string Destination
        {
            get { return destination; }
        }

        public int Number
        {
            get { return number; }
        }

        public DateTime Time
        {
            get { return time; }
        }
    }
}
