using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Example1Test
    {
        [TestCase(1, "��ł�")]
        [TestCase(2, "�����ł�")]
        [TestCase(3, "��ł�")]
        [TestCase(828, "�����ł�")]
        [TestCase(2413, "��ł�")]
        [TestCase(-295636, "�����ł�")]
        public void Test(int number, string answer)
        {
            var result = new Example1().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}