using System;
using System.Text;
using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    class BinaryTests
    {

        public string BinaryString(int value)
        {
            StringBuilder builder = new StringBuilder();
            StringBuilder reversebuilder = new StringBuilder();
            int temp = 0;

            while(value > 0)
            {
                temp = value % 2;
                builder.Append(temp);
                value = value / 2;
            }

            for (int i = builder.Length - 1; i >= 0; i--)
            {
                reversebuilder.Append(builder[i]);
            }

            return reversebuilder.ToString();
        }

        [Test]
        public void BinaryTest()
        {
            Assert.AreEqual("11", BinaryString(3));
            Assert.AreEqual("110", BinaryString(6));
            int value = Convert.ToInt32(BinaryString(6), 2);
            Assert.AreEqual(6, value);
           
        }
    }
}
