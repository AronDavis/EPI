using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._6
{
    /// <summary>
    /// Given an array of integers, return whether or not it is possible to advance to the last index in the array.
    /// You must start from the beginning of the array.
    /// Advancement is limited to the value at the index you are currently on. 
    ///     Ex: A[0] = 2, from there you can advance to A[1] or A[2]
    ///     Ex: A[1] = 3, from there you can advance to A[2], A[3], or A[4]
    /// </summary>
    public class _6_4
    {
        public static bool Run(int[] data)
        {
            int reach = 0;

            //loop through our data until we can go no further or we reach the end of the array
            for (int i = 0; i <= reach && reach < data.Length; i++)
                reach = Math.Max(reach, data[i] + i);

            return reach >= data.Length - 1;
        }
    }
}
