using NUnit.Framework;
using WorkBookAnswer;

namespace WorkBookTest
{
    [TestFixture]
    public class Question4Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(1996, "うるう年です")]
        [TestCase(1900, "うるう年ではありません")]
        [TestCase(2000, "うるう年です")]
        [TestCase(1999, "うるう年ではありません")]
        [TestCase(824, "うるう年です")]
        [TestCase(700, "うるう年ではありません")]
        public void Test(int number, string answer)
        {
            //var result = new Question4().Answer(number);
            var result = new Question4().Answer(number);
            Assert.AreEqual(result, answer);
        }
    }
}