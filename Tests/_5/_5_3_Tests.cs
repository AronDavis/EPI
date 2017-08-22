using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._5;

namespace Tests
{
    [TestClass]
    public class _5_3_Tests
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(_5_3.Run(0) == 0);
            Assert.IsTrue(_5_3.Run(1) == ((long)1 << 63));
            Assert.IsTrue(_5_3.Run(2) == ((long)1 << 62));
        }
    }
}
