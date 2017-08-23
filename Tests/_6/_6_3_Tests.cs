using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._6;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class _6_3_Tests
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(_6_3.Run("0", "0") == "0");
            Assert.IsTrue(_6_3.Run("0", "-0") == "0");
            Assert.IsTrue(_6_3.Run("1", "-0") == "0");
            Assert.IsTrue(_6_3.Run("1", "1") == "1");
            Assert.IsTrue(_6_3.Run("-1", "1") == "-1");
            Assert.IsTrue(_6_3.Run("-1", "-1") == "1");
            Assert.IsTrue(_6_3.Run("3", "7") == "21");
            Assert.IsTrue(_6_3.Run("3", "-7") == "-21");
            Assert.IsTrue(_6_3.Run("-7", "-3") == "21");
        }
    }
}
