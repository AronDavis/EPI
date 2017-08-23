using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._6;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class _6_6_Tests
    {
        [TestMethod]
        public void Test()
        {
            int[] data = new int[]
            {
                1, 2, 2, 3, 3, 3, 4, 4, 4, 4
            };
            Assert.IsTrue(_6_6.Run(data) == 4);
            Assert.IsTrue(data[0] == 1);
            Assert.IsTrue(data[1] == 2);
            Assert.IsTrue(data[2] == 3);
            Assert.IsTrue(data[3] == 4);
        }
    }
}
