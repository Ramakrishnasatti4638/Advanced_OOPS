using System;
using System.Collections.Generic;
namespace LinearSearch2;
class Program 
{
    public static void Main(string[] args)
    {
        List<string> list=new List<string>()
        {
            "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" 
        };
        string elementToFind="SF3067";
        bool found=false;
        for(int i=0;i<list.Count;i++)
        {
            if(list[i].Equals(elementToFind))
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