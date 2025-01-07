namespace Iterator.Interfaces
{
    public interface IAggregate<T>
    {
        void AddItem(T item);
        IIterator<T> CreateIterator();
    }
}
