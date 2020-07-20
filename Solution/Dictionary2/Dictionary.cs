namespace Dictionary2
{
    class Dictionary<TKey, TValue>
    {
        private readonly MyList<TKey> key;
        private readonly MyList <TValue> value;

        public Dictionary()
        {
            key = new MyList<TKey>();
            value = new MyList<TValue>();
        }

        public void AddToDictionary(TKey k, TValue v)
        {
            key.Add(k);
            value.Add(v);
        }

        public string this[int index]
        {
            get { return key[index] + " " + value[index]; }
        }

        public string this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if ((string)(object)key[i] == (string)(object)index)
                    {
                        return "По ключу " + index.ToString() + " найдено значение: " + value[i].ToString();
                    }
                }
                return "По ключу " + index + " не найдено значения.";
            }
        }

        public int Length
        {
            get { return key.Count; }
        }

        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < key.Count; i++)
            {
                str += key[i] + " " + value[i] + "\n";
            }

            if (str != null)
                return str;
            return "В словаре нет значений.";
        }
    }
}