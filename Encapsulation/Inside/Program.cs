using System;
namespace Inside;
public class Program 
{
    public static void Main(string[] args)
    {
        
        First first=new First();
        System.Console.WriteLine(first.PrivateOut);
        System.Console.WriteLine(first.PublicNumber);

        Second second=new Second();
        System.Console.WriteLine(second.ProtectedNumberOut);
        System.Console.WriteLine(second.ProtectedInternalOut);
    }
}