using System.Runtime.CompilerServices;

namespace IteratorPatternDemo
{
    public class ConcreteAggregator : IAggregator
    {
        private readonly List<Item> _collectionList = new();
        public ConcreteIterator GetEnumerator()
        {
            return new ConcreteIterator(this);
        }
        public void Add(string name, int marks)
        {
            _collectionList.Add(new Item(name,marks));
        }
        public Item this[int index]
        {
            get { return _collectionList[index]; }
            set { _collectionList.Add(value); }
        }
        public int Size()
        {
            return _collectionList.Count;
        }

    }
}
