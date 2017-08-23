using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._6
{
    /// <summary>
    /// Given two strings that represent integers, return the integer representing their product (as a string)
    /// </summary>
    public class _6_3
    {
        public static string Run(string num1, string num2)
        {
            bool isPositive = true;

            if (num1[0] == '-')
            {
                isPositive = false;
                num1 = num1.Substring(1);
            }

            if (num2[0] == '-')
            {
                isPositive = !isPositive;
                num2 = num2.Substring(1);
            }

            //reverse to make multiplication easier
            num1 = new string(num1.Reverse().ToArray());
            num2 = new string(num2.Reverse().ToArray());

            int[] result = new int[num1.Length + num2.Length + 1];

            for (int i = 0; i < num1.Length; i++)
            {
                for(int j = 0; j < num2.Length; j++)
                {
                    // - '0' to convert to int
                    result[i + j] += (num1[i] - '0') * (num2[j] - '0');
                    result[i + j + 1] += result[i + j] / 10;
                    result[i + j] %= 10;
                }
            }

            //remove excess leading 0s
            int index = num1.Length + num2.Length;
            while (result[index] == 0 && index != 0)
                index--;

            StringBuilder sb = new StringBuilder();
            if (!isPositive && result[index] != 0)
                sb.Append('-');

            while (index >= 0)
            {
                sb.Append(result[index]);
                index--;
            }

            return sb.ToString();
        }
    }
}
