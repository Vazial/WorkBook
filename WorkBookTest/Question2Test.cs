using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Question2Test
    {
        [TestCase(6, "6の倍数です")]
        [TestCase(3, "3の倍数です")]
        [TestCase(5, "")]
        [TestCase(1590, "6の倍数です")]
        [TestCase(8529, "3の倍数です")]
        [TestCase(2519, "")]
        public void Test(int number, string answer)
        {
            //var result = new Question2().Answer(number);
            var result = new Question2().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}