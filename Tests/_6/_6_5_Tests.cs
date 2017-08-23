using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._6;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class _6_5_Tests
    {
        [TestMethod]
        public void Test()
        {
            int[] data = new int[]
            {
                5, 3, 7, 11, 2, 3, 13, 5, 7
            };
            Assert.IsTrue(_6_5.Run(data, 3) == 7);
            Assert.IsTrue(data[0] == 5);
            Assert.IsTrue(data[1] == 7);
            Assert.IsTrue(data[2] == 11);
            Assert.IsTrue(data[3] == 2);
            Assert.IsTrue(data[4] == 13);
            Assert.IsTrue(data[5] == 5);
            Assert.IsTrue(data[6] == 7);
        }
    }
}
