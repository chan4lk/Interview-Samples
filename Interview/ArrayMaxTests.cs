using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    class ArrayMaxTests
    {

        public int GetMaxium(int[] arr)
        {
            int max = arr[0];
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]> max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        [Test]
        public void MaxTest()
        {
            Assert.AreEqual(5, GetMaxium(new int[] { 2, 4, 5 }));
            Assert.AreEqual(14, GetMaxium(new int[] { 2, 4, 5, 14 }));
        }
    }
}
