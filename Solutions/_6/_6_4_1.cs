using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._6
{
    /// <summary>
    /// Given an array of integers, return the number of steps needed to advance to the last index in the array.
    /// You must start from the beginning of the array.
    /// Advancement is limited to the value at the index you are currently on. 
    ///     Ex: A[0] = 2, from there you can advance to A[1] or A[2]
    ///     Ex: A[1] = 3, from there you can advance to A[2], A[3], or A[4]
    /// Assume that the input will always be able to advance to the end.
    /// </summary>
    public class _6_4_1
    {
        public static int Run(int[] data)
        {
            int reach = 0;
            int numSteps = 1;
            //loop through our data until we can go no further or we reach the end of the array
            for (int i = 0; i <= reach && reach < data.Length; i++)
            {
                int localReach = data[i] + i;

                if (localReach > reach)
                {
                    reach = localReach;
                    numSteps++;
                }
            }

            return numSteps;
        }
    }
}
