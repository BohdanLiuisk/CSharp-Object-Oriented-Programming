namespace ArrayByGenerics
{
    public interface IArrayList<T>
    {
        void Add(T num);
        T this [int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}
