using System;
namespace QN2;
public class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Rmakrishna","Murali","9441882121");
        EmployeeInfo employee=new EmployeeInfo("Uday","Reddy");
        EmployeeInfo employee1=new EmployeeInfo("Rama","Krishna");
        student.Display();
        Console.WriteLine();
        employee.Display();
        Console.WriteLine();
        employee1.Display();
    }
}