using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Example1Test
    {
        [TestCase(1, "Šï”‚Å‚·")]
        [TestCase(2, "‹ô”‚Å‚·")]
        [TestCase(3, "Šï”‚Å‚·")]
        [TestCase(828, "‹ô”‚Å‚·")]
        [TestCase(2413, "Šï”‚Å‚·")]
        [TestCase(-295636, "‹ô”‚Å‚·")]
        public void Test(int number, string answer)
        {
            var result = new Example1().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}