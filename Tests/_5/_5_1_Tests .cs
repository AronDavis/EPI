using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._5;

namespace Tests
{
    [TestClass]
    public class _5_1_Tests
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(_5_1.Run(0) == 0);
            Assert.IsTrue(_5_1.Run(1) == 1);
            Assert.IsTrue(_5_1.Run(2) == 1);
            Assert.IsTrue(_5_1.Run(3) == 0);
            Assert.IsTrue(_5_1.Run(7) == 1);
        }
    }
}
