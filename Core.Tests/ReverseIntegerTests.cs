namespace Core.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReverseIntegerTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new ReverseInteger().Go2(123);
            Assert.AreEqual(321, r);
        }

        [TestMethod]
        public void Case2()
        {
            var r = new ReverseInteger().Go2(-123);
            Assert.AreEqual(-321, r);
        }

        [TestMethod]
        public void Case3()
        {
            var r = new ReverseInteger().Go2(120);
            Assert.AreEqual(21, r);
        }

        [TestMethod]
        public void Case4()
        {
            var r = new ReverseInteger().Go2(0);
            Assert.AreEqual(0, r);
        }

        [TestMethod]
        public void Case6()
        {
            var r = new ReverseInteger().Go2(12345);
            Assert.AreEqual(54321, r);
        }

        [TestMethod]
        public void Case5()
        {
            var r = new ReverseInteger().Go2(1534236469);
            //Assert.AreEqual(9646324351, r);
            Assert.AreEqual(0, r);
        }

        [TestMethod]
        public void Case7()
        {
            var r = new ReverseInteger().Go2(1563847412);
            Assert.AreEqual(0, r);
        }

    }
}