using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    class GCDTests
    {

        public int GCD(int a, int b)
        {
            if (b > 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
