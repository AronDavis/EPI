using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions._6
{
    /// <summary>
    /// How would you compute the parity of a very large number of 64-bit words?  The parity of a binary word is 1 if the number of 1s is odd.  Otherwise it is 0.
    /// </summary>
    public class _6_1
    {
        public static void Run(int pivotIndex, int[] data)
        {
            int pivot = data[pivotIndex];

            int smaller = 0;
            int equal = 0;
            int larger = data.Length - 1;

            while(equal <= larger)
            {
                if (data[equal] < pivot)
                    swap(smaller++, equal++, data);
                else if (data[equal] == pivot)
                    ++equal;
                else
                    swap(equal, larger--, data);
            }
        }

        private static void swap(int i, int j, int[] data)
        {
            int temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}
