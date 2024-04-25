using System;
namespace Sorting3;
class Program 
{
    public static void Main(string[] args)
    {
        char[] arr = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", arr));

        QuickSort quickSort = new QuickSort();
        quickSort.Sort(arr, 0, arr.Length - 1);


        System.Console.WriteLine("Ascending order");
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", arr));

        System.Console.WriteLine("Decending order");
        Console.WriteLine("Sorted array:");
        Array.Reverse(arr);
        Console.WriteLine(string.Join(", ", arr));
    }
}