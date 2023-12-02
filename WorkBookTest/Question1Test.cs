using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Question1Test
    {
        [TestCase(2, "3�̔{���ł͂���܂���")]
        [TestCase(3, "3�̔{���ł�")]
        [TestCase(4, "3�̔{���ł͂���܂���")]
        [TestCase(828, "3�̔{���ł�")]
        [TestCase(2412, "3�̔{���ł�")]
        [TestCase(-2956, "3�̔{���ł͂���܂���")]
        public void Test(int number, string answer)
        {
            var result = new Question1().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}