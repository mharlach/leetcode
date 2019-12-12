namespace Core.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ValidParenthesisTests
    {
        [TestMethod]
        public void Case1()
        {
            var r = new ValidParentheses().IsValid("()");
            Assert.AreEqual(true,r);
        }

        [TestMethod]
        public void Case2()
        {
            var r = new ValidParentheses().IsValid("()[]{}");
            Assert.AreEqual(true,r);
        }

        [TestMethod]
        public void Case3()
        {
            var r = new ValidParentheses().IsValid("(]");
            Assert.AreEqual(false,r);
        }

        [TestMethod]
        public void Case4()
        {
            var r = new ValidParentheses().IsValid("([)]");
            Assert.AreEqual(false,r);
        }

        [TestMethod]
        public void Case5()
        {
            var r = new ValidParentheses().IsValid("{[]}");
            Assert.AreEqual(true,r);
        }

        
    }
}