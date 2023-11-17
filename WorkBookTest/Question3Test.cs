using NUnit.Framework;
using WorkBookAnswer;

namespace WorkBookTest
{
    [TestFixture]
    public class Question3Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(1999, "20¢‹I‚Å‚·")]
        [TestCase(2000, "20¢‹I‚Å‚·")]
        [TestCase(2001, "21¢‹I‚Å‚·")]
        [TestCase(42807, "429¢‹I‚Å‚·")]
        [TestCase(0, "1¢‹I‚Å‚·")]
        public void Test(int number, string answer)
        {
            //var result = new Question3().Answer(number);
            var result = new Question3().Answer(number);
            Assert.AreEqual(result, answer);
        }
    }
}