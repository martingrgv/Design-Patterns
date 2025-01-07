namespace Iterator.Interfaces
{
    public interface IIterator<TAggregate>
    {
        bool HasNext();
        TAggregate Next();
    }
}
