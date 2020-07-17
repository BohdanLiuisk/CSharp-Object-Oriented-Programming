namespace MyDictionaryGenerics
{
    class Dictionary<TKey, TValue>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

        public int Lenght
        {
            get { return lenght; }
        }

        public Dictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "An attempt to access the array.";
            }
        }

        public void Add(int i, TKey k, TValue l)
        {
            key[i] = k;
            value[i] = l;
        }
    }
}
