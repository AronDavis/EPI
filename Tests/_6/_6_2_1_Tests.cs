using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._6;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class _6_2_1_Tests
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(_6_2_1.Run("0", "0") == "0");
            Assert.IsTrue(_6_2_1.Run("1", "0") == "1");
            Assert.IsTrue(_6_2_1.Run("1", "1") == "10");
            Assert.IsTrue(_6_2_1.Run("11", "1") == "100");
            Assert.IsTrue(_6_2_1.Run("1", "11") == "100");
            Assert.IsTrue(_6_2_1.Run("100", "1") == "101");
            Assert.IsTrue(_6_2_1.Run("001", "1") == "010");
        }
    }
}
