using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    public class FactorialTests
    {

        public int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        [Test]
        public void FactorialTest()
        {
            Assert.AreEqual(1, Factorial(0));
            Assert.AreEqual(1, Factorial(1));
            Assert.AreEqual(2, Factorial(2));
        }

    }
}
