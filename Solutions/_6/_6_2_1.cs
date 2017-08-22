using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._6
{
    /// <summary>
    /// Given two strings of bits, add them together and return the resulting string of bits.
    /// </summary>
    public class _6_2_1
    {
        public static string Run(string num1, string num2)
        {
            string min;
            string max;

            if (num1.Length < num2.Length)
            {
                min = num1;
                max = num2;
            }
            else
            {
                min = num2;
                max = num1;
            }

            StringBuilder result = new StringBuilder();
            int carry = 0;
            for(int i = 0; i < max.Length; i++)
            {
                int bit1 = 0;

                if (i < min.Length)
                    bit1 = parse(min[min.Length - 1 - i]);

                int bit2 = parse(max[max.Length - 1 - i]);

                int sum = bit1 + bit2 + carry;

                //if our sum will overflow
                if (sum > 1)
                {
                    int num = sum % 2;
                    carry = sum-1;

                    result.Insert(0, num);
                }
                else //no overflow
                {
                    //reset carry
                    carry = 0;

                    result.Insert(0, sum);
                }
            }

            //if we had any carry left at the end
            while (carry > 0)
            {
                result.Insert(0, carry % 2);
                carry--;
            }

            return result.ToString();
        }

        private static int parse(char bit)
        {
            if (bit == '0')
                return 0;
            else
                return 1;
        }
    }
}
