using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Question1Test
    {
        [TestCase(2, "3‚Ì”{”‚Å‚Í‚ ‚è‚Ü‚¹‚ñ")]
        [TestCase(3, "3‚Ì”{”‚Å‚·")]
        [TestCase(4, "3‚Ì”{”‚Å‚Í‚ ‚è‚Ü‚¹‚ñ")]
        [TestCase(828, "3‚Ì”{”‚Å‚·")]
        [TestCase(2412, "3‚Ì”{”‚Å‚·")]
        [TestCase(-2956, "3‚Ì”{”‚Å‚Í‚ ‚è‚Ü‚¹‚ñ")]
        public void Test(int number, string answer)
        {
            var result = new Question1().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}