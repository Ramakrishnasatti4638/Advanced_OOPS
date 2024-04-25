using System;
namespace ByType;
public class Program 
{
    public static void Main(string[] args)
    {
        //Add method to add integers
        System.Console.WriteLine(Add(1,2));
        System.Console.WriteLine(Add("2","3"));
        System.Console.WriteLine(Add(2,3));

    }

    public static int Add(int a,int b)
    {
        return a+b;
    }
    public static double Add(double a,double b)
    {
        return a+b;
    }
    public static string Add(string a,string b)
    {
        return a+b;
    }
}