using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._6;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class _6_4_1_Tests
    {
        [TestMethod]
        public void Test()
        {
            int[] data = new int[]
            {
                0
            };
            Assert.IsTrue(_6_4_1.Run(data) == 1);

            data = new int[]
            {
                2, 0, 0
            };
            Assert.IsTrue(_6_4_1.Run(data) == 2);

            data = new int[]
            {
                1, 1, 1, 1, 1, 1
            };
            Assert.IsTrue(_6_4_1.Run(data) == 7);

            data = new int[]
            {
                2, 4, 1, 1, 0, 2, 3
            };
            Assert.IsTrue(_6_4_1.Run(data) == 4);

            data = new int[]
            {
                3, 3, 1, 0, 2, 0, 1
            };
            Assert.IsTrue(_6_4_1.Run(data) == 5);
        }
    }
}
