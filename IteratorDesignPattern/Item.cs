namespace IteratorPatternDemo
{
    public class Item
    {
        public Item(string studentName, int studentMarks)
        {
            _mName = studentName;
            if ((studentMarks >= 0) && (studentMarks <= 100))
            {
                _mMarks = studentMarks;
            }
            else
            {
                throw new ArgumentOutOfRangeException("All students marks must be lesser than 100.");
            }
        }
        public string Name()
        {
            return _mName;
        }
        public int Marks()
        {
            return _mMarks;
        }
        private readonly string _mName;
        private readonly int _mMarks;
    }
}
