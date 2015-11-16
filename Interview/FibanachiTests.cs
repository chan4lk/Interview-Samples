using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    class FibanachiTests
    {

        public int Fibanachi(int n)
        {
            if (n <2)
            {
                return n;
            }
            else
            {
                return Fibanachi(n - 1) + Fibanachi(n - 2);
            }
        }
        
        public int FibnachiIter(int n)
        {
            int[] val = new int[n];
            if (n == 1 || n == 2)
            {
                return n;
            }
            else {
                val[1] = 1;
                val[2] = 2;
                for (int i = 3; i < n; i++)
                {
                    val[i] = val[i - 1] + val[i - 2];
                }           
            }
            return val[n - 1];
        }

        public int FibanachiIterV2(int n)
        {
            int nextLast = 1;
            int last = 1;
            int result = 1;

            for (int i = 2; i < n; i++)
            {
                result = nextLast + last;
                nextLast = last;
                last = result;
            }

            return result;
        }

        [Test]
        public void FibnachiTest()
        {
            Assert.AreEqual(21, Fibanachi(8));
        }


        [Test]
        public void FibnachiIterTest()
        {
            Assert.AreEqual(21, FibnachiIter(8));
        }

        [Test]
        public void FibnachiIterV2Test()
        {
            Assert.AreEqual(21, FibanachiIterV2(8));
        }
    }
}
