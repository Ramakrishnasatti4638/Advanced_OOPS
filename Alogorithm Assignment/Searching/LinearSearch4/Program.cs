using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace LinearSearch4;
class Program 
{
    public static void Main(string[] args)
    {
        List<double> list=new List<double>()
        {
            	1.1,65.3,93.9,55.5,3.5,6.9
        };
        double elementToFind=3.5;
        bool found=false;
        for(int i=0;i<list.Count;i++)
        {
            if(list[i]==elementToFind)
            {
                System.Console.WriteLine($"Element {elementToFind} is found at position {i}");
                found=true;
                break;
            }
        }
        if(!found)
        {
            System.Console.WriteLine("Element not found");
        }
    }
}