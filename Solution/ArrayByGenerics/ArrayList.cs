using System;

namespace ArrayByGenerics
{
    class ArrayList<T> : IArrayList<T>
    {
        private T[] array;
        
        public ArrayList()
        {
            array = new T[0];
        }

        public void Add(T num)
        {
            T[] tempArray = new T[array.Length + 1];

            for(int i = 0; i < array.Length; i ++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = num;
            array = tempArray;
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public int Count
        {
            get { return array.Length; }
        }

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + " ";
            }
            return "Array length: " + array.Length + "\nArray elements: " + stroka;
        }
    }
}