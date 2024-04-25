using System;
namespace QN1;
public class Program 
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("Ramakrishna",Gender.Male,new DateTime(2002,03,21),"9441882121");
        employee.Display();
        Console.WriteLine("-----------------------------------------------------");
        EmployeeInfo employee1=new EmployeeInfo("Thanuja",Gender.Female,new DateTime(2000,05,17),"9492245872");
        employee1.Display();
        Console.WriteLine("-----------------------------------------------------");
        employee1.Update("Thanuja",Gender.Female,new DateTime(2000,05,17),"9490172121");
        employee1.Display();
    }
}