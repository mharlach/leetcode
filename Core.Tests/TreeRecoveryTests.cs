namespace Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TreeRecoveryTests
    {
        [TestMethod]
        public void Case1()
        {
           var r = new TreeRecovery().RecoverFromPreorder("1-2--3--4-5--6--7");
           
        }

       

    }
}