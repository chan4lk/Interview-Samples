using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    class AnagramTests
    {
        [Test]
        public void AnagramTest()
        {
            Assert.AreEqual(true, AreStringsAnagrams("momdad", "dadmom"));
            Assert.AreEqual(false, AreStringsAnagrams("momdads", "dadmom"));
            Assert.AreEqual(true, AreStringsAnagrams("momdads", "dsadmom"));
        }

        public static bool AreStringsAnagrams(string a, string b)
        {
            bool areAnagrams = true;
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                bool matached = false;

                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {                        
                        matached = true;
                        index = j;
                        
                    }
                }

                b.Remove(index);

                if (matached == false)
                {
                    return false;
                }
            }

            return areAnagrams;
        }

    }
}
