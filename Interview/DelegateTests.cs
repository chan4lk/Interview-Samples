using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview
{
    [TestClass]
    public class DelegateTests
    {
        public delegate string MyDel(string id);

        [TestMethod]
        public void TestMethod1()
        {
            MyDel del = new MyDel(MyMethod);
            del += MyMethod2;
            del += MyMethod3;

            string res = del("NewS");

            Assert.AreEqual("News", res);
        }


        /// <summary>
        /// Mies the method.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// to lower
        /// </returns>
        public string MyMethod(string id)
        {
            return id.ToLower();
        }

        public string MyMethod2(string id)
        {
            return id.ToUpper();
        }

        public string MyMethod3(string id)
        {
            id = id.ToLower();

            return char.ToUpper(id[0]) + id.Substring(1);
        }
    }
}
