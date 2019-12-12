namespace Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RomanToIntegerTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new RomanToInteger().RomanToInt("III");
            Assert.AreEqual(3, r);
        }

        [TestMethod]
        public void Case2()
        {
            var r = new RomanToInteger().RomanToInt("IV");
            Assert.AreEqual(4, r);
        }

        [TestMethod]
        public void Case3()
        {
            var r = new RomanToInteger().RomanToInt("IX");
            Assert.AreEqual(9, r);
        }

        [TestMethod]
        public void Case4()
        {
            var r = new RomanToInteger().RomanToInt("LVIII");
            Assert.AreEqual(58, r);
        }

        [TestMethod]
        public void Case5()
        {
            var r = new RomanToInteger().RomanToInt("MCMXCIV");
            Assert.AreEqual(1994, r);
        }

    }
}