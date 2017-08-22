using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._5;

namespace Tests
{
    [TestClass]
    public class _5_5_Tests
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(_5_5.Run(0, 0) == 0);

            Assert.IsTrue(_5_5.Run(0, 1) == 0);

            Assert.IsTrue(_5_5.Run(1, 0) == 0);

            Assert.IsTrue(_5_5.Run(1, 1) == 1);

            Assert.IsTrue(_5_5.Run(3, 7) == 21);

            Assert.IsTrue(_5_5.Run(7, 3) == 21);
        }
    }
}
