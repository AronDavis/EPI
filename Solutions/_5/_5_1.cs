using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions._5
{
    /// <summary>
    /// How would you compute the parity of a very large number of 64-bit words?  The parity of a binary word is 1 if the number of 1s is odd.  Otherwise it is 0.
    /// </summary>
    public class _5_1
    {
        public static ulong Run(ulong data)
        {
            ulong result = 0;
            while(data > 0)
            {
                //XOR
                result ^= 1;

                //drop the lowest set bit in data
                data &= (data - 1); 
            }

            return result;
        }
    }
}
