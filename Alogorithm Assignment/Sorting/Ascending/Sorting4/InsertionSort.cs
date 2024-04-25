using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting4
{
    public class InsertionSort
    {
        public double[] NumArray { get; set; }

        public double[] SortArray()
        {
            int arrayLength = NumArray.Length;
            for (int i = 1; i < arrayLength; i++)
            {
                double key = NumArray[i];
                int j = i - 1;

                // Move elements of NumArray[0..i-1] that are greater than key
                // to one position ahead of their current position
                while (j >= 0 && NumArray[j] > key)
                {
                    NumArray[j + 1] = NumArray[j];
                    j--;
                }
                NumArray[j + 1] = key;
            }

            return NumArray;
        }
    }
}