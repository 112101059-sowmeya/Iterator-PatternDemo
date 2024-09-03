
namespace IteratorPatternDemo
{
    public interface IAggregator
    {
        ConcreteIterator GetEnumerator();
        public void Add(string itemName, int marks);
    }
}
