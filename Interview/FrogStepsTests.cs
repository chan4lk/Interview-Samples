using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    class FrogStepsTests
    {
        public int NumberOfWays(int n)
        {
            int ways = 0;

            int minSteps = n / 2;
            int singleStep = n % 2;

            ways = 1 + (minSteps * 2) * 2;

            return ways;
        }

        [Test]
        public void WaysTest()
        {
            Assert.AreEqual(3, NumberOfWays(3));
            Assert.AreEqual(5, NumberOfWays(5));

        }
    }
}
