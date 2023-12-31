using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Example1Test
    {
        [TestCase(1, "奇数です")]
        [TestCase(2, "偶数です")]
        [TestCase(3, "奇数です")]
        [TestCase(828, "偶数です")]
        [TestCase(2413, "奇数です")]
        [TestCase(-295636, "偶数です")]
        public void Test(int number, string answer)
        {
            var result = new Example1().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}