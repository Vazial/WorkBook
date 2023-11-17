using NUnit.Framework;
using WorkBookAnswer;

namespace WorkBookTest
{
    [TestFixture]
    public class Question3Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(1999, "20���I�ł�")]
        [TestCase(2000, "20���I�ł�")]
        [TestCase(2001, "21���I�ł�")]
        [TestCase(42807, "429���I�ł�")]
        [TestCase(0, "1���I�ł�")]
        public void Test(int number, string answer)
        {
            //var result = new Question3().Answer(number);
            var result = new Question3().Answer(number);
            Assert.AreEqual(result, answer);
        }
    }
}