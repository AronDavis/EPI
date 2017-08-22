using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions._5
{
    /// <summary>
    /// Write a function that takes a 64-bit word and returns that 64-bit word but with bits reversed.
    /// </summary>
    public class _5_3
    {
        public static long Run(long data)
        {
            //NOTE: book says to precompute and use a lookup table
            long reversed = 0;
            for(int i = 0; i < 64; i++)
            {
                //push bit of concern to front and isolate
                long bit = (data >> i) & 1;

                //set it at the appropriate reverse position
                reversed ^= (bit << (63-i));
            }
            return reversed;
        }
    }
}
