using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions._5
{
    /// <summary>
    /// Implement code that takes as input a 64-bit integer and swaps the bits in that integer at indicies i and j.
    /// </summary>
    public class _5_2
    {
        public static long Run(long data, int firstIndex, int secondIndex)
        {
            //shift so that bit of concern is at the front, then & 1 to isolate
            long firstBit = (data >> firstIndex) & 1;
            long secondBit = (data >> secondIndex) & 1;

            if (firstBit == secondBit)
                return data;

            int firstMask = 1 << firstIndex;
            int secondMask = 1 << secondIndex;
            int joinedMask = firstMask | secondMask;

            //XOR to flip
            data ^= joinedMask;

            return data;
        }
    }
}
