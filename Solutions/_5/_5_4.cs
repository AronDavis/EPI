using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions._5
{
    /// <summary>
    /// Write a function that takes an unsigned 64-bit integer and a number that
    ///     a) has the same number of bits flagged
    ///     b) is a different number
    ///     c) is as close to the original number as possible while still abiding by A and B
    /// You can assuming the input will not be 0 or all 1s.
    /// </summary>
    public class _5_4
    {
        public static long Run(long data)
        {
            for(int i = 0; i < 63; i++)
            {
                int j = i + 1;
                //push bit of concern to front and isolate
                long bit = (data >> i) & 1;
                long nextBit = (data >> j) & 1;

                //if they differ, swap them
                if(bit != nextBit)
                {
                    //flip the two bits (which is swapping them because they are different)
                    data ^= (1 << i) | (1 << j);
                    return data;
                }
            }

            return data;
        }
    }
}
