using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting2
{
    public class MergeSort
    {
        void Merge(string[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        // Create temporary arrays
        string[] left = new string[n1];
        string[] right = new string[n2];

        // Copy data to temporary arrays left[] and right[]
        for (int i = 0; i < n1; ++i)
            left[i] = arr[l + i];
        for (int j = 0; j < n2; ++j)
            right[j] = arr[m + 1 + j];

        // Merge the temporary arrays back into arr[l..r]
        int x = 0, y = 0;
        int k = l;
        while (x < n1 && y < n2)
        {
            if (string.Compare(left[x], right[y]) <= 0)
            {
                arr[k] = left[x];
                x++;
            }
            else
            {
                arr[k] = right[y];
                y++;
            }
            k++;
        }

        // Copy remaining elements of left[], if any
        while (x < n1)
        {
            arr[k] = left[x];
            x++;
            k++;
        }

        // Copy remaining elements of right[], if any
        while (y < n2)
        {
            arr[k] = right[y];
            y++;
            k++;
        }
    }

    // Main function that sorts arr[l..r] using merge()
    public void Sort(string[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;

            // Sort first and second halves
            Sort(arr, l, m);
            Sort(arr, m + 1, r);

            // Merge the sorted halves
            Merge(arr, l, m, r);
        }
    }
    }
}