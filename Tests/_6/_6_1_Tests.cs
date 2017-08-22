using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._6;

namespace Tests
{
    [TestClass]
    public class _6_1_Tests
    {
        [TestMethod]
        public void Test()
        {
            int[] data = new int[]
            {
                3, 1, 2, 1, 3, 1
            };

            _6_1.Run(2, data);

            Assert.IsTrue(1 == data[0]);
            Assert.IsTrue(1 == data[1]);
            Assert.IsTrue(1 == data[2]);
            Assert.IsTrue(2 == data[3]);
            Assert.IsTrue(3 == data[4]);
            Assert.IsTrue(3 == data[5]);
        }
    }
}
