using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._5;

namespace Tests
{
    [TestClass]
    public class _5_2_Tests
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(_5_2.Run(1, 1, 0 ) == 2);
            Assert.IsTrue(_5_2.Run(1, 0, 1) == 2);
            Assert.IsTrue(_5_2.Run(3, 0, 1) == 3);
            Assert.IsTrue(_5_2.Run(5, 1, 1) == 5);
            Assert.IsTrue(_5_2.Run(5, 1, 2) == 3);
        }
    }
}
