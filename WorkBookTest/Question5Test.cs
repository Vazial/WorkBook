using NUnit.Framework;
using WorkBookAnswer;

namespace WorkBookTest
{
    [TestFixture]
    public class Question5Test
    {
        [TestCase(4, 0)]
        [TestCase(5, 1)]
        [TestCase(6, 2)]
        [TestCase(7, 3)]
        [TestCase(0, 0)]
        [TestCase(3, 3)]
        [TestCase(1276, 0)]
        [TestCase(-3929, -1)]
        [TestCase(38070, 2)]
        [TestCase(-86575, -3)]
        public void Test(int number, int answer)
        {
            //var result = new Question5().Answer(number);
            var result = new Question5().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}