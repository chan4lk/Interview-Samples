using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace Interview
{
    /// <summary>
    /// Summary description for LockTests
    /// </summary>
    [TestClass]
    public class LockTests
    {
        public LockTests()
        {
            List<int> l = new List<int>();
            LinkedList<int> i = new LinkedList<int>();
            Collection<int> c = new Collection<int>();
            l.BinarySearch(1);
            
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        private static object lockThis = new object();

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            lock (lockThis)
            {

            }
        }
    }
}
