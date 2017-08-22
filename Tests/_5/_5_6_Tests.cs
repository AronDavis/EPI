using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._5;

namespace Tests
{
    [TestClass]
    public class _5_6_Tests
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(_5_6.Run(0, 1) == 0);

            Assert.IsTrue(_5_6.Run(0, 7) == 0);

            Assert.IsTrue(_5_6.Run(1, 1) == 1);

            Assert.IsTrue(_5_6.Run(3, 3) == 1);

            Assert.IsTrue(_5_6.Run(7, 3) == 2);
        }
    }
}
