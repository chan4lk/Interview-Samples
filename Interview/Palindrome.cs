using System;
using System.Diagnostics;
using NUnit.Framework;

namespace Interview
{
    /// <summary>
    /// Summary description for Palindrome
    /// </summary>
    [TestFixture]
    public class Palindrome
    {
        /// <summary>
        /// The start time.
        /// </summary>
        TimeSpan _startTime;

        /// <summary>
        /// The end time.
        /// </summary>
        TimeSpan _endTime;

        /// <summary>
        /// Determines whether the specified string is palindrome1.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static bool IsPalindrome1(string str)
        {
            string reverse = string.Empty;
            str = str.Replace(".", "").ToLower();

            for (var i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            Debug.Write(reverse);

            return reverse == str;
        }

        /// <summary>
        /// Determines whether the specified string is palindrome.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static bool IsPalindrome(string str)
        {
            bool isPalindrome = true;

            str = str.Replace(".", "").ToLower();
            for (int i = 0; i < str.Length/2 +1; i++)
            {
                if (str[i] == str[str.Length - i - 1]) continue;
                isPalindrome = false;
                break;
            }

            return isPalindrome;
        }

        /// <summary>
        /// Palindromes the test.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="expected">if set to <c>true</c> [expected].</param>
        [TestCase("Noel sees Leon.", true)]
        [TestCase("Noel sees Leons.", false)]
        public void PalindromeTest(string str, bool expected)
        {
            _startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            Assert.AreEqual(IsPalindrome(str), expected);
            _endTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            Debug.WriteLine("process time {0}", _endTime - _startTime);
        }
    }
}
