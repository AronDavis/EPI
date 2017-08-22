using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions._5;

namespace Tests
{
    [TestClass]
    public class _5_4_Tests
    {
        [TestMethod]
        public void Test()
        {
            //01 -> 10
            Assert.IsTrue(_5_4.Run(1) == 2);

            //10 -> 01
            Assert.IsTrue(_5_4.Run(2) == 1);

            //011 -> 101
            Assert.IsTrue(_5_4.Run(3) == 5);

            //101 -> 110
            Assert.IsTrue(_5_4.Run(5) == 6);
        }
    }
}
