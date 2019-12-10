namespace Core.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AtoiTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new Atoi().MyAtoi("42");
            Assert.AreEqual(42, r);
        }

        [TestMethod]
        public void Case2()
        {
            var r = new Atoi().MyAtoi("   -42");
            Assert.AreEqual(-42, r);
        }

        [TestMethod]
        public void Case3()
        {
            var r = new Atoi().MyAtoi("4193 with words");
            Assert.AreEqual(4193, r);
        }

        [TestMethod]
        public void Case4()
        {
            var r = new Atoi().MyAtoi("words and 987");
            Assert.AreEqual(0, r);
        }

        [TestMethod]
        public void Case5()
        {
            var r = new Atoi().MyAtoi("-91283472332");
            Assert.AreEqual(-2147483648, r);
        }
    }
}