using System;
namespace QN4;
public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("------------------------Ladies wear---------------------------");
        LadiesWear ladiesWear=new LadiesWear();
        ladiesWear.GetDressInfo();
        ladiesWear.DisplayInfo();

        Console.WriteLine("------------------------Mens Wear-----------------------------");
        MensWear mensWear=new MensWear();
        mensWear.GetDressInfo();
        mensWear.DisplayInfo();
    }
}