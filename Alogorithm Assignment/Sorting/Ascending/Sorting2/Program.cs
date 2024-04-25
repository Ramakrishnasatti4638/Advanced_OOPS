using System;
namespace Sorting2;
class Program 
{
    public static void Main(string[] args)
    {
        string[] arr = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        int n = arr.Length;

        Console.WriteLine("Original array:");
        foreach (string element in arr)
            Console.Write(element + " ");

        MergeSort mergeSort = new MergeSort();
        mergeSort.Sort(arr, 0, n - 1);

        System.Console.WriteLine("Ascending order");
        Console.WriteLine("\nSorted array:");
        foreach (string element in arr)
            Console.Write(element + " ");

        System.Console.WriteLine("Desending order");
        Console.WriteLine("\nSorted array:");
        Array.Reverse(arr);
        foreach (string element in arr)
            Console.Write(element + " ");

    }

    

}