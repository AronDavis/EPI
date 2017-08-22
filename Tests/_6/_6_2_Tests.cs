using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._6;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class _6_2_Tests
    {
        [TestMethod]
        public void Test()
        {
            List<int> data = new List<int>
            {
                1, 2, 9, 9
            };

            _6_2.Run(data);

            Assert.IsTrue(1 == data[0]);
            Assert.IsTrue(3 == data[1]);
            Assert.IsTrue(0 == data[2]);
            Assert.IsTrue(0 == data[3]);

            data = new List<int>
            {
                9
            };

            _6_2.Run(data);

            Assert.IsTrue(1 == data[0]);
            Assert.IsTrue(0 == data[1]);
        }
    }
}
