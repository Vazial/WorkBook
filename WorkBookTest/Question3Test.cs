using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Question3Test
    {
        [TestCase(1999, "20世紀です")]
        [TestCase(2000, "20世紀です")]
        [TestCase(2001, "21世紀です")]
        [TestCase(42807, "429世紀です")]
        [TestCase(0, "1世紀です")]
        public void Test(int number, string answer)
        {
            //var result = new Question3().Answer(number);
            var result = new Question3().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}