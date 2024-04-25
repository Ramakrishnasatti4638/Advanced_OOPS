using System;
namespace QN7;
class Program 
{
    public static void Main(string[] args)
    {
        Attendance month1=new Attendance(24,2,1);
        Attendance month2=new Attendance(24,0,0);
        Attendance month3=new Attendance(24,5,0);
        Console.WriteLine(month1.CalculateSalary());
        Console.WriteLine(month2.CalculateSalary());
        Console.WriteLine(month3.CalculateSalary());
    }
}