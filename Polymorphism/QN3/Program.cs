using System;
namespace QN3;
class Program 
{
    public static void Main(string[] args)
    {
        EEEDepartment eEEDepartment=new EEEDepartment();
        eEEDepartment.SetBookInfo();
        eEEDepartment.DisplayInfo();
        System.Console.WriteLine("-----------------------------");
        CSEDepartment cSEDepartment=new CSEDepartment();
        cSEDepartment.SetBookInfo();
        cSEDepartment.DisplayInfo();
    }
}