namespace Core.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegerToRomanTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new IntegerToRoman().IntToRoman(3);
            Assert.AreEqual("III", r);
        }

        [TestMethod]
        public void Case2()
        {
            var r = new IntegerToRoman().IntToRoman(4);
            Assert.AreEqual("IV", r);
        }

        [TestMethod]
        public void Case3()
        {
            var r = new IntegerToRoman().IntToRoman(9);
            Assert.AreEqual("IX", r);
        }

        [TestMethod]
        public void Case4()
        {
            var r = new IntegerToRoman().IntToRoman(58);
            Assert.AreEqual("LVIII", r);
        }

        [TestMethod]
        public void Case5()
        {
            var r = new IntegerToRoman().IntToRoman(1994);
            Assert.AreEqual("MCMXCIV", r);
        }

    }
}