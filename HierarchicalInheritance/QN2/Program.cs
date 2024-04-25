using System;
namespace QN2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Permanent");
        PermanantEmployee permanantEmployee=new PermanantEmployee(12000.00,4,EmployeeType.Permanent);
        permanantEmployee.ShowSalary();

        System.Console.WriteLine("Temporary");
        TemporaryEmployee temporaryEmployee=new TemporaryEmployee(12000.00,4,TemporaryEmployee.EmployeeType1.Temporary);
        temporaryEmployee.ShowSalary();
    }
}
