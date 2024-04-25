using System;
using System.Collections.Generic;
namespace BinarySearch4;
class Program 
{
    public static void Main(string[] args)
    {
        List<double> list=new List<double>()
        {
            1.1,65.3,93.9,55.5,3.5,6.9
        };
        double elementToFind=3.5;
        list.Sort();
        int res=BinarySearch(list,elementToFind);
        if(res==-1)
        {
            System.Console.WriteLine("Element not found");
        }
        else
        {
            System.Console.WriteLine("Element found at position : "+res);
        }

    }
    public static int BinarySearch(List<double> list,double element)
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