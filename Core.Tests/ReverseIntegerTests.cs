namespace Core.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReverseIntegerTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new ReverseInteger().Go(123);
            Assert.AreEqual(321, r);
        }

        [TestMethod]
        public void Case2()
        {
            var r = new ReverseInteger().Go(-123);
            Assert.AreEqual(-321, r);
        }

        [TestMethod]
        public void Case3()
        {
            var r = new ReverseInteger().Go(120);
            Assert.AreEqual(21, r);
        }

        [TestMethod]
        public void Case4()
        {
            var r = new ReverseInteger().Go(0);
            Assert.AreEqual(0, r);
        }
    }
}