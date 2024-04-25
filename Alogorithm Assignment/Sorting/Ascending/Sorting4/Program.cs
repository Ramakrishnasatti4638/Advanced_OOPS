using System;
namespace Sorting4;
class Program 
{
    public static void Main(string[] args)
    {
        //Selection sort

        double[] arr = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", arr));

        SelectionSort selectionSort = new SelectionSort();
        selectionSort.NumArray = arr;
        double[] sortedArray = selectionSort.SortArray();

        System.Console.WriteLine("Selection Sort");
        System.Console.WriteLine("Assending order");
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", sortedArray));

        System.Console.WriteLine("Desending order");
        Array.Reverse(sortedArray);
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", sortedArray));


        //Insertion sort
        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", arr));

        InsertionSort insertionSort = new InsertionSort();
        insertionSort.NumArray = arr;
        double[] sortedArray1 = insertionSort.SortArray();

        System.Console.WriteLine("Asending order");
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", sortedArray1));

        System.Console.WriteLine("Desending order");
        Array.Reverse(sortedArray1);
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", sortedArray1));
    }
}