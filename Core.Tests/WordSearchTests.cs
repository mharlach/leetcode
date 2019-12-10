namespace Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordSearchTests
    {
        [TestMethod]
        public void Case1()
        {
            var board = new char[][]
            {
                new char[]{'A','B','C','E'},
                 new char[]{'S','F','C','S'},
                 new char[]{'A','D','E','E'}
            };

            var r = new WordSearch().Exist(board, "ABCCED");
            Assert.AreEqual(true, r);
        }

        [TestMethod]
        public void Case2()
        {
            var board = new char[][]
            {
                new char[]{'C','C','A'},
                 new char[]{'A','A','A'},
                 new char[]{'B','C','D'}
            };

            var r = new WordSearch().Exist(board, "AAB");
            Assert.AreEqual(true, r);
        }

        [TestMethod]
        public void Case3()
        {
            // [['A','B','C','E'],['S','F','E','S'],['A','D','E','E']]
            var board = new char[][]
            {
                new char[]{'A','B','C','E'},
                 new char[]{'S','F','E','S'},
                 new char[]{'A','D','E','E'}
            };

            var r = new WordSearch().Exist(board, "ABCEFSADEESE");
            Assert.AreEqual(true, r);
        }

    }
}