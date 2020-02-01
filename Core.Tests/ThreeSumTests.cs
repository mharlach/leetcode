namespace Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ThreeSumTests
    {
        [TestMethod]
        public void Case1()
        {
            var nums = new int[]{-1, 0, 1, 2, -1, -4};
            var results = new ThreeSum().Go(nums);
            Assert.AreEqual(2,results.Count);
            CollectionAssert.AreEqual(new List<int>{-1,0,1},results[0].ToList());
            CollectionAssert.AreEqual(new List<int>{-1,-1,2},results[1].ToList());
        }
    }
}