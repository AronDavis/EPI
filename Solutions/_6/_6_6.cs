using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._6
{
    /// <summary>
    /// Given an array of sorted integers, update the array so that all duplicates are removed and the remaining elements are shifted to the left.
    /// Return the number of remaining elements.
    /// There are no requirements as to the values stored beyond the last valid element.
    /// </summary>
    public class _6_6
    {
        public static int Run(int[] data)
        {
            int writeIndex = 0;
            
            for (int i = 1; i < data.Length; i++)
            {
                if(data[writeIndex] != data[i])
                {
                    writeIndex++;
                    data[writeIndex] = data[i];
                }
            }

            return writeIndex + 1;
        }
    }
}
