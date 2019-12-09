using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Tests
{
    [TestClass]
    public class ZigZag
    {
        [TestMethod]
        public void Case1()
        {
            var zigZag = new Core.ZigZag().Convert("PAYPALISHIRING",3);
            Assert.AreEqual(zigZag,"PAHNAPLSIIGYIR");
            
        }
    }
}