using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._6
{
    /// <summary>
    /// Given an array of integers, find the smallest positive number which is not present in the array.
    /// You do not need to preserve the contents of the array.
    /// </summary>
    public class _6_7
    {
        public static int Run(int[] data)
        {
            int i = 0;
            while(i < data.Length)
            {
                if (data[i] > 0
                    && data[i] <= data.Length
                    && data[data[i] - 1] != data[i]
                    )
                {
                    swap(i, data[i] - 1, data);
                }
                else
                    i++;
            }

            for(i = 0; i < data.Length; i++)
            {
                if (data[i] != i + 1)
                    return i + 1;
            }

            return data.Length + 1;
        }

        private static void swap(int i, int j, int[] data)
        {
            int temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}
