namespace Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MovingStonesTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new MovingStones().NumMoveStones(1, 2, 5);
            Assert.AreEqual(new int[] { 1, 2 }, r);
        }

        [TestMethod]
        public void Case2()
        {
            var r = new MovingStones().NumMoveStones(4, 3, 2);
            Assert.AreEqual(new int[] { 0, 0 }, r);
        }

        [TestMethod]
        public void Case3()
        {
            var r = new MovingStones().NumMoveStones(3, 5, 1);
            Assert.AreEqual(new int[] { 1, 2 }, r);
        }

        [TestMethod]
        public void Case4()
        {
            var r = new MovingStones().NumMoveStones(7, 4, 1);
            Assert.AreEqual(new int[] { 2, 4 }, r);
        }

    }
}