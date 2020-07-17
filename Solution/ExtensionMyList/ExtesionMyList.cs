namespace ExtensionMyList
{
    static class ExtesionMyList
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var temp = new T[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
    }
}
