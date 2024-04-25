using System;
using System.Collections.Generic;
namespace BinariSearch1;
class Program 
{
    public static void Main(string[] args)
    {
        List<int> list=new List<int>()
        {
            45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77
        };
        int elementToFind=66;
        list.Sort();
        foreach(int value in list)
        {
            System.Console.Write(value+" ");
        }
        int result=BinarySearch(list,elementToFind);
        if(result==-1)
        {
            System.Console.WriteLine("Element not found");
        }
        else
        {
            System.Console.WriteLine($"Element found at position {result}");
        }
    }

    public static int BinarySearch(List<int> list,int element)
    {
        int left=0,right=list.Count-1;
        while(left<=right)
        {
            int middle=left+(right-left)/2;
            if(list[middle]==element)
            {
                return middle;
            }
            else if(list[middle]<element)
            {
                left=middle+1;
            }
            else
            {
                right=middle-1;
            }
        }
        return -1;
    }
}