using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions._5
{
    /// <summary>
    /// Write a function that multiplies two unsigned positive integers.  The only operators allowed are assignment and bitwise.
    /// </summary>
    public class _5_5
    {
        public static uint Run(uint num1, uint num2)
        {
            uint sum = 0;
            while(num1 > 0)
            {
                //examine every bit in num1
                if((num1 & 1) > 0)
                    sum = add(sum, num2);

                num1 >>= 1;
                num2 <<= 1;
            }
            return sum;
        }

        private static uint add(uint num1, uint num2)
        {
            uint sum = 0;
            uint carryin = 0;
            uint k = 1;
            uint temp1 = num1;
            uint temp2 = num2;

            while(temp1 > 0 || temp2 > 0)
            {
                uint k1 = num1 & k;
                uint k2 = num2 & k;

                uint carryout = (k1 & k2) | (k1 & carryin) | (k2 & carryin);
                sum |= (k1 ^ k2 ^ carryin);
                carryin = carryout << 1;
                k <<= 1;
                temp1 >>= 1;
                temp2 >>= 1;
            }

            return sum | carryin;
        }
    }
}
