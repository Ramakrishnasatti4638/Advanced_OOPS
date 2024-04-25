using System;
using System.Collections.Generic;
namespace BinarySearch2;
class Program 
{
    public static void Main(string[] args)
    {
        List<string> list=new List<string>()
        {
            "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" 
        };
        string elementToFind="SF3067";
        list.Sort();
        int result=BinarySearch(list,elementToFind);
        if(result==-1)
        {
            System.Console.WriteLine("Element not found");
        }
        else
        {
            System.Console.WriteLine("Element found at position: "+result);
        }
        
    }

    public static int BinarySearch(List<string> list,string element)
    {
        int left=0,right=list.Count-1;
        while(left<=right)
        {
            int middle=left+(right-left)/2;
            if(list[middle].Equals(element))
            {
                return middle;
            }
            else if(string.Compare(list[middle],element)<0)
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