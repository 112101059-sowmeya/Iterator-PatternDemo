using Microsoft.VisualStudio.TestTools.UnitTesting;
using IteratorPatternDemo;

namespace UnitTests
{
    [TestClass]
    public class IteratorUnitTests
    {
        [TestMethod]
        public void CollectionIterating()
        {
            List<string> testList = ["Sowmeya", "Madhavan", "Kala", "Raajah" ];
            ConcreteAggregator studentCollection = new();
            studentCollection.Add("Sowmeya",50);
            studentCollection.Add("Madhavan", 80);
            studentCollection.Add("Kala", 90);
            studentCollection.Add("Raajah", 95);
            ConcreteIterator enumerator = studentCollection.GetEnumerator();
            List<string> parsedItemsList = new();
            while (enumerator.MoveNext() == true)
            {
                Item item = enumerator.CurrentItem();
                parsedItemsList.Add(item.Name());
            }
            Assert.IsTrue(Enumerable.SequenceEqual(parsedItemsList, testList));
        }

        [TestMethod]
        public void CorrectElementReturnCallback()
        {
            List<string> testList = ["Student A","Student B"];
            int requiredIndex = 1;
            ConcreteAggregator studentCollection = new();
            ConcreteIterator enumerator = studentCollection.GetEnumerator();
            int currentIndex = 0;
            while (enumerator.MoveNext() == true)
            {
                Item item = enumerator.CurrentItem();
                if (currentIndex == requiredIndex)
                {
                    Assert.IsTrue( testList[currentIndex] == item.Name() );
                }
                currentIndex++;
            }
        }

        [TestMethod]
        public void EmptyCollectionIterating()
        {
            List<string> testList = [];
            ConcreteAggregator studentCollection = new();
            ConcreteIterator enumerator = studentCollection.GetEnumerator();

            List<string> parsedItemsList = new();

            while (enumerator.MoveNext() == true)
            {
                Item item = enumerator.CurrentItem();
                parsedItemsList.Add(item.Name());
            }
            Assert.IsTrue(Enumerable.SequenceEqual(parsedItemsList, testList));
        }
    }
}
