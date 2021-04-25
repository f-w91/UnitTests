using NUnit.Framework;
using Test;

namespace AppTest
{
    [TestFixture]
    public class UnitTest1
    {

        [Test]
        public void Test_Add()
        {
            var expected = 10;

            var actual = Program.Add(5, 5);

            Assert.AreEqual(expected, actual, "5 + 5 is 10");
        }

        [Test]
        public void Test_Subtract()
        {
            var expected = 5;

            var actual = Program.Subtract(10, 5);

            Assert.AreEqual(expected, actual, "10 - 5 is 5");
        }

        [Test]
        public void Test_Square()
        {
            var expected = 25;

            var actual = Program.Square(5);

            Assert.AreEqual(expected, actual, "5 * 5 is 25");
        }
    }
}
