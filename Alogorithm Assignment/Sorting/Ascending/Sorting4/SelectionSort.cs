using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting4
{
    public class SelectionSort
    {
        public double[] NumArray { get; set; }

        public double[] SortArray()
        {
            int arrayLength = NumArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int smallestIndex = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (NumArray[j] < NumArray[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                // Swap the smallest value with the current position
                double temp = NumArray[smallestIndex];
                NumArray[smallestIndex] = NumArray[i];
                NumArray[i] = temp;
            }

            return NumArray;
        }
    }
}
