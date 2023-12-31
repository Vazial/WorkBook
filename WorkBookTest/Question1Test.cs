using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Question1Test
    {
        [TestCase(2, "3の倍数ではありません")]
        [TestCase(3, "3の倍数です")]
        [TestCase(4, "3の倍数ではありません")]
        [TestCase(828, "3の倍数です")]
        [TestCase(2412, "3の倍数です")]
        [TestCase(-2956, "3の倍数ではありません")]
        public void Test(int number, string answer)
        {
            var result = new Question1().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}