namespace Core.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestCommonPrefixTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new LongestCommonPrefix().Go(new string[]{"flower","flow","flight"});
            Assert.AreEqual("fl", r);
        }

        [TestMethod]
        public void Case2()
        {
            var r = new LongestCommonPrefix().Go(new string[]{"dog","racecar","car"});
            Assert.AreEqual("", r);
        }
    }
}