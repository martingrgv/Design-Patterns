using Iterator.Interfaces;

namespace Iterator
{
    public class ConcreteIterator<T> : IIterator<T>
    {
        private readonly List<T> _aggregate;
        private int _position = 0;

        public ConcreteIterator(List<T> aggregate)
        {
            _aggregate = aggregate;   
        }

        public bool HasNext() => _position < _aggregate.Count();

        public T Next()
        {
            if (!HasNext())
                throw new InvalidOperationException("No more elements!");

            return _aggregate[_position++];
        }
    }
}
