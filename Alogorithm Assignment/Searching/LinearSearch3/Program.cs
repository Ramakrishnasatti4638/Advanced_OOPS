using System;
using System.Collections.Generic;
namespace LinearSearch3;
class Program 
{
    public static void Main(string[] args)
    {

        List<char> list=new List<char>()
        {
            'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d' 
        };
        char elementToFind='m';
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