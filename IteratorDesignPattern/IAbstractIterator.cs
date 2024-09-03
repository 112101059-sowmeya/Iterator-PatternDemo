namespace IteratorPatternDemo
{
    public interface IAbstractIterator
    {
        Item First();
        Item CurrentItem();
        bool MoveNext();
    }
}
