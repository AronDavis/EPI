using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions._6
{
    /// <summary>
    /// Given a list that represents a number, modify the list to represent that number + 1.
    /// </summary>
    public class _6_2
    {
        public static void Run(List<int> data)
        {
            int carry = 1;
            for(int i = data.Count-1; i >= 0; i--)
            {
                int current = data[i];

                int currentWithCarry = current + carry;

                //if our sum will overflow
                if (currentWithCarry >= 10)
                {
                    //pull from the ones place
                    data[i] = currentWithCarry % 10;

                    //drop what's in the ones place and shift
                    carry = currentWithCarry / 10;
                }
                else //no overflow
                {
                    //add
                    data[i] += carry;

                    //reset carry
                    carry = 0;
                }
            }

            //if we had any carry left at the end
            if (carry != 0)
                data.Insert(0, carry);
        }
    }
}
