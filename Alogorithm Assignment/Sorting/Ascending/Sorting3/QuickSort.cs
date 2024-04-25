using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting3
{
    public class QuickSort
    {
        // Partition function to rearrange elements around a pivot
        public int Partition(char[] arr, int low, int high)
        {
            char pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }

            Swap(ref arr[i + 1], ref arr[high]);
            return i + 1;
        }

        // QuickSort function
        public void Sort(char[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);

                Sort(arr, low, partitionIndex - 1);
                Sort(arr, partitionIndex + 1, high);
            }
        }

        // Swap two characters
        void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

    }
}