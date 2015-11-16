using NUnit.Framework;

namespace Interview
{
    [TestFixture]
    public class DiamondTests
    {
        [Test]
        public void DiamondTest()
        {
            Concreate1 c1 = new Concreate1();
            c1.Kill();
            Assert.IsTrue(true); 
        }

        [Test]
        public void OverrideBase1Test()
        {
            IBase1 b = new Concreate2();
            b.Kill();
        }

        [Test]
        public void OverrideBase2Test()
        {
            IBase2 b = new Concreate2();
            b.Kill();
        }

        [Test]
        public void Override1Test()
        {
            Concreate1 b = new Concreate2();
            b.Kill();
        }

        [Test]
        public void Override2Test()
        {
            Concreate2 b = new Concreate2();
            b.Kill();
        }

        [Test]
        public void Override3Test()
        {
            Concreate1 b = new Concreate3();
            b.Kill();
        }

        [Test]
        public void Override3NewTest()
        {
            Concreate1 b = new Concreate3();
            ((Concreate3)b).Test();
            b.Kill();
        }
    }
}
