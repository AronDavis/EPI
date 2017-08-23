using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._6
{
    /// <summary>
    /// Given an array of integers and a value 'k', update the array so that all occurrences of k are removed and the remaining elements are shifted to the left.
    /// Return the number of remaining elements.
    /// There are no requirements as to the values stored beyond the last valid element.
    /// </summary>
    public class _6_5
    {
        public static int Run(int[] data, int k)
        {
            int writeIndex = 0;
            
            for (int i = 0; i < data.Length; i++)
            {
                int current = data[i];
                if(current != k)
                {
                    data[writeIndex] = current;
                    writeIndex++;
                }
            }

            return writeIndex;
        }
    }
}
