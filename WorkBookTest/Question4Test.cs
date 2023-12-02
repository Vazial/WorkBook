using NUnit.Framework;
using WorkBook;

namespace WorkBookTest
{
    [TestFixture]
    public class Question4Test
    {
        [TestCase(1996, "���邤�N�ł�")]
        [TestCase(1900, "���邤�N�ł͂���܂���")]
        [TestCase(2000, "���邤�N�ł�")]
        [TestCase(1999, "���邤�N�ł͂���܂���")]
        [TestCase(824, "���邤�N�ł�")]
        [TestCase(700, "���邤�N�ł͂���܂���")]
        public void Test(int number, string answer)
        {
            //var result = new Question4().Answer(number);
            var result = new Question4().Answer(number);
            Assert.AreEqual(answer, result);
        }
    }
}