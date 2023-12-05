using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Question2Test
    {
        [TestCase(6, "6‚Ì”{”‚Å‚·")]
        [TestCase(3, "3‚Ì”{”‚Å‚·")]
        [TestCase(5, "")]
        [TestCase(1590, "6‚Ì”{”‚Å‚·")]
        [TestCase(8529, "3‚Ì”{”‚Å‚·")]
        [TestCase(2519, "")]
        public void Test(int number, string answer)
        {
            //var result = new Question2().Answer(number);
            var result = new Question2().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}