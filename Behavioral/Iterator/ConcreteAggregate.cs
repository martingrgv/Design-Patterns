using Iterator.Interfaces;

namespace Iterator
{
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private List<T> _aggregate;

        public ConcreteAggregate()
        {
            _aggregate = new List<T>();
        }

        public ConcreteAggregate(List<T> aggregate)
        {
            _aggregate = aggregate;   
        }

        public void AddItem(T item)
        {
            _aggregate.Add(item);
        }

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(_aggregate);
        }
    }
}
