using System.Diagnostics;
using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    public class HornerTests
    {
        /// <summary>
        /// Horners the specified a.
        /// </summary>
        /// <param name="a">
        /// a.
        /// </param>
        /// <param name="n">
        /// The n.
        /// </param>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        public int Horner(int[] a, int n, int x)
        {
            var result = a[n];

            for (var i = n - 1; i >= 0; i--)
            {
                result = result * x + a[i];
            }

            Debug.Write(result);

            return result;
        }

        /// <summary>
        /// Horners the test.
        /// </summary>
        [Test]
        public void HornerTest()
        {
            int[] a = { 1, 2, 3 };
            const int x = 2;
            const int n = 2;

            Assert.AreEqual(17, Horner(a, n, x));
            Assert.AreEqual(90, Horner(a, n, 5));
        }
    }
}
