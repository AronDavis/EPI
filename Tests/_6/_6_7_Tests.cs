using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._6;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class _6_7_Tests
    {
        [TestMethod]
        public void Test()
        {
            int[] data = new int[]
            {
                3, 4, 0, 2
            };
            Assert.IsTrue(_6_7.Run(data) == 1);

            data = new int[]
            {
                0, 2, 3, 4,
            };
            Assert.IsTrue(_6_7.Run(data) == 1);

            data = new int[]
            {
                1, 2, 3, 4, 5, 6, 7
            };
            Assert.IsTrue(_6_7.Run(data) == 8);

            data = new int[]
            {
                -1
            };
            Assert.IsTrue(_6_7.Run(data) == 1);

            data = new int[]
            {
                0
            };
            Assert.IsTrue(_6_7.Run(data) == 1);

            data = new int[0];
            Assert.IsTrue(_6_7.Run(data) == 1);
        }
    }
}
