using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    class IntToRomanTests
    {

        public string Roman(int n)
        {
            string[] labels = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] sizes = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            int repeat;
            string output = string.Empty;

            for (int i = 0; n > 0; i++)
            {
                repeat = n / sizes[i];
                for (int j = 0; j < repeat; j++)
                {
                    output += labels[i];
                }

                n = n % sizes[i];
            }

            return output;
        }

        [Test]
        public void RomanTest()
        {
            Assert.AreEqual("XC", Roman(90));
            Assert.AreEqual("XII", Roman(12));
            try
            {

            }
            finally
            {
                
            }
        }     

        public static bool operator ==(IntToRomanTests a, IntToRomanTests b) { return a.Equals(b); }
        public static bool operator !=(IntToRomanTests a, IntToRomanTests b) { return !a.Equals(b); }
    }
}
