using System;
namespace QN2;
public class Program 
{
    public static void Main(string[] args)
    {
        EEEdepartment eEEdepartment=new EEEdepartment();
        eEEdepartment.SetBookInfo();
        eEEdepartment.DisplayInfo();

        Console.WriteLine();
        CSEdepartment cSEdepartment=new CSEdepartment();
        cSEdepartment.SetBookInfo();
        cSEdepartment.DisplayInfo();
    }
}