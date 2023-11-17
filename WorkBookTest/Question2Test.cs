using NUnit.Framework;
using WorkBookAnswer;

namespace WorkBookTest
{
    [TestFixture]
    public class Question2Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(6, "6�̔{���ł�")]
        [TestCase(3, "3�̔{���ł�")]
        [TestCase(5, "")]
        [TestCase(1590, "6�̔{���ł�")]
        [TestCase(-8529, "3�̔{���ł�")]
        [TestCase(2519, "")]
        public void Test(int number, string answer)
        {
            //var result = new Question2().Answer(number);
            var result = new Question2().Answer(number);
            Assert.AreEqual(result, answer);
        }
    }
}