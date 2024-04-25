using System;
using System.Collections.Generic;
namespace BinarySearch3;
class Program 
{
    public static void Main(string[] args)
    {
        List<char> list=new List<char>()
        {
            'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'
        };
        char elementToFind='m';
        list.Sort();
        int result=BinarySearch(list,elementToFind);
        if(result==-1)
        {
            System.Console.WriteLine("Element not found");
        }
        else
        {
            System.Console.WriteLine("Element found at position "+result);
        }
    }

    public static int BinarySearch(List<char> list,char element)
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