using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace Interview
{

    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    class LongestCommonStringTests
    {
        /// <summary>
        /// Initializes the <see cref="LongestCommonStringTests"/> class.
        /// </summary>
        static LongestCommonStringTests() {
        }

        /// <summary>
        /// Tests this instance.
        /// </summary>
        void Test()
        {
            Collection<int> ids = new Collection<int>();
            char c = 'c';
            string id1 = "chan";
            String id = "Chan";

        }

        /// <summary>
        /// Longest  the sub string.
        /// </summary>
        /// <param name="word1">The word1.</param>
        /// <param name="word2">The word2.</param>
        /// <param name="wArray1">The w array1.</param>
        /// <param name="wArray2">The w array2.</param>
        /// <param name="arr">The arr.</param>
        public void LcSubString(string word1,
                                string word2,
                                string[] wArray1,
                                string[] wArray2,
                                int[,] arr)
        {
            int len1, len2;
            len1 = word1.Length;
            len2 = word2.Length;

            for (int k = 0; k < word1.Length; k++)
            {
                wArray1[k] = word1[k].ToString();
                wArray2[k] = word2[k].ToString();
            }

            for (int i = len1 - 1; i >= 0; i--)
            {
                for (int j = len2 - 1; j >= 0; j--)
                {
                    if (wArray1[i] == wArray2[j])
                    {
                        arr[i, j] = 1 + arr[i + 1, j + 1];
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }
        }//end LCS

        /// <summary>
        /// Shows the string.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="wArray">The w array.</param>
        /// <returns></returns>
        string ShowString(int[,] arr, string[] wArray)
        {
            string substring = string.Empty;
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1); j++)
                {
                    if (arr[i, j] > 0)
                    {
                        substring += wArray[j];
                    }
                }
            }

            return substring;
        }

        /// <summary>
        /// Displays the string.
        /// </summary>
        /// <param name="arr">The arr.</param>
        void DisplayString(int[,] arr)
        {
            for (int row = 0; row < arr.GetUpperBound(0); row++)
            {
                for (int col = 0; col < arr.GetUpperBound(1); col++)
                {
                    Console.Write(arr[row, col]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// LCSs the test.
        /// </summary>
        /// <param name="word1">The word1.</param>
        /// <param name="word2">The word2.</param>
        /// <param name="expected">The expected.</param>
        [TestCase("maven", "havloc", "av")]
        [TestCase("chandima", "andichand", "chand")]
        [TestCase("dismika", "smilenow", "smi")]
        public void LCSTest(string word1, string word2, string expected)
        {
            string[] wArray1 = new string[word1.Length];
            string[] wArray2 = new string[word2.Length];
            string subStr;

            int[,] lArray = new int[word1.Length, word2.Length];

            LcSubString(word1, word2, wArray1, wArray2, lArray);

            DisplayString(lArray);
            subStr = ShowString(lArray, wArray1);
            Trace.WriteLine(subStr);
            Assert.AreEqual(expected, subStr);
        }

        
    }
}
