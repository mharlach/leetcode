namespace Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LetterCombinationTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new LetterCombinations().Go("23");
            var expected = new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

            CollectionAssert.AreEqual(expected, r.ToArray());
        }


    }
}