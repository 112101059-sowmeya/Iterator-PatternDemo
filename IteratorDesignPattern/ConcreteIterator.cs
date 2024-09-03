namespace IteratorPatternDemo
{
    public class ConcreteIterator : IAbstractIterator
    {
        public ConcreteIterator(ConcreteAggregator collection)
        {
            _mCollection = collection;
        }
        public Item First()
        {
            if (_mCollection == null)
            {
                return null;
            }
            _mCurrentIndex = 0;
            return _mCollection[_mCurrentIndex];
        }
        public Item CurrentItem()
        {
            if (_mCollection == null)
            {
                return null;
            }
            return _mCollection[_mCurrentIndex];
        }
        public bool MoveNext()
        {
            if (_mCurrentIndex+1 >=  _mCollection.Size())
            {
                return false;
            }
            _mCurrentIndex += 1;
            return true;
        }
        private int _mCurrentIndex = -1;
        private readonly ConcreteAggregator _mCollection;
    }
}
