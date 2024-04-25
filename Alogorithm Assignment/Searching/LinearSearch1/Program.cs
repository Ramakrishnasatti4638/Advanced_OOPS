using System;
using System.Collections.Generic;
namespace LinearSearch1;
class Program 
{
    public static void Main(string[] args)
    {
        List<int> list1=new List<int>()
        {
            45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77  
        };
        int elementToFind=66;
        bool found=false;
        for(int i=0;i<list1.Count;i++)
        {
            if(list1[i]==elementToFind)
            {
                System.Console.WriteLine($"Element {elementToFind} found at postion: {i}");
                found=true;
                break;
            }
        }
        if(!found)
        {
            System.Console.WriteLine("Not found");
        }

    }

    
}