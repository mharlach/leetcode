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
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var results = new ThreeSum().Go(nums);
            Assert.AreEqual(2, results.Count);
            CollectionAssert.AreEqual(new List<int> { -1, 0, 1 }, results[0].ToList());
            CollectionAssert.AreEqual(new List<int> { -1, -1, 2 }, results[1].ToList());
        }
    }

    [TestClass]
    public class MergeTwoListsTests
    {
        [TestMethod]
        public void Case1()
        {
            var l1 = new MergeTwoLists.ListNode(1)
            {
                next = new MergeTwoLists.ListNode(2)
                {
                    next = new MergeTwoLists.ListNode(4)
                }
            };

            var l2 = new MergeTwoLists.ListNode(1)
            {
                next = new MergeTwoLists.ListNode(3)
                {
                    next = new MergeTwoLists.ListNode(4)
                }
            };
            var results = new MergeTwoLists().Go(l1, l2);

            var expected = new List<int> { 1, 1, 2, 3, 4, 4 };
            CollectionAssert.AreEqual(expected,results.GetFull());
        }
    }
}