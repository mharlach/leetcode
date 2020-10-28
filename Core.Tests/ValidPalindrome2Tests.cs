using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.ValidPalindrome2;

namespace Core.Tests
{
    [TestClass]
    public class ValidPalindrome2Tests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(new Solution().ValidPalindrome("deeee"));
        }
    }
}