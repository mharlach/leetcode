using System;
using Core.MergeTwoSortedLists;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Core.Tests
{
    [TestClass]
    public class MergeTwoSortedListsTests
    {
        [TestMethod]
        public void Test_1()
        {
            var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            var sln = new Solution().MergeTwoLists(l1, l2);

            var s = sln.ToString();//.Should().Be("1,1,2,3,4");
            s.Should().Be("1,1,2,3,4,4");

        }

        [TestMethod]
        public void Test_2()
        {
            ListNode l1 = null;
            ListNode l2 = new ListNode(0);//, new ListNode(3, new ListNode(4)));

            var sln = new Solution().MergeTwoLists(l1, l2);

            var s = sln.ToString();//.Should().Be("1,1,2,3,4");
            s.Should().Be("0");

        }

        [TestMethod]
        public void Test_3()
        {
            var l1 = new ListNode(-9, new ListNode(3));
            var l2 = new ListNode(5, new ListNode(7));

            var sln = new Solution().MergeTwoLists(l1, l2);

            var s = sln.ToString();//.Should().Be("1,1,2,3,4");
            s.Should().Be("-9,3,5,7");

        }

        [TestMethod]
        public void Test_4()
        {
            var l1 = new ListNode(-9, new ListNode(-7, new ListNode(-3, new ListNode(-3, new ListNode(-1, new ListNode(2, new ListNode(3)))))));
            var l2 = new ListNode(-7, new ListNode(-7, new ListNode(-6, new ListNode(-6, new ListNode(-5, new ListNode(-3, new ListNode(2, new ListNode(4))))))));

            var sln = new Solution().MergeTwoLists(l1, l2);

            var s = sln.ToString();//.Should().Be("1,1,2,3,4");
            s.Should().Be("-9,-7,-7,-7,-6,-6,-5,-3,-3,-3,-1,2,2,3,4");

        }

    }
}
