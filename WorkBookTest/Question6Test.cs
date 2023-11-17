using NUnit.Framework;
using WorkBookAnswer;

namespace WorkBookTest
{
    [TestFixture]
    public class Question6Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(55)]
        public void Test(int answer)
        {
            //var result = new Question6().Answer(number);
            var result = new Question6().Answer();
            Assert.AreEqual(result, answer);
        }
    }
}