namespace ExtensionMyList
{
    class MyList<T>
    {
        private readonly int length;
        private readonly T[] array;

        public int Length
        {
            get { return length; }
        }

        public MyList(int n)
        {
            array = new T[n];
            length = array.Length;
        }

        public T this[int i]
        {
            get { return array[i]; }
        }

        public void Add(int i, T k)
        {
            array[i] = k;
        }
    }
}