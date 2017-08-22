using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions._5
{
    /// <summary>
    /// Given two positive integers, compute their quotient (aka divide), using only the addition, subtraction, and shift operators.
    /// </summary>
    public class _5_6
    {
        public static uint Run(uint num1, uint num2)
        {
            uint result = 0;
            while(num1 >= num2)
            {
                int power = 1;
                //prevent overflow
                while(
                    (num2 << power) >= (num2 << (power-1)) 
                    && (num2 << power) <= num1
                    )
                {
                    ++power;
                }

                result = (uint)1 << (power - 1);
                num1 -= num2 << (power - 1);
            }

            return result;
        }
    }
}
