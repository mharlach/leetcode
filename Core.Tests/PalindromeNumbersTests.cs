namespace Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PalindromeNumbersTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new PalindromeNumber().IsPalidrome(121);
            Assert.AreEqual(true, r);
        }

        [TestMethod]
        public void Case2()
        {
            var r = new PalindromeNumber().IsPalidrome(-121);
            Assert.AreEqual(false, r);
        }

        [TestMethod]
        public void Case3()
        {
            var r = new PalindromeNumber().IsPalidrome(10);
            Assert.AreEqual(false, r);
        }

    }
}