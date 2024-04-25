using System;
namespace QN5;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personalInfo;
        EmployeeInfo employeeInfo=new EmployeeInfo("Ramakrishna","Murali","9441882121",Gender.Male);
        personalInfo=employeeInfo;
        personalInfo.Display();
        System.Console.WriteLine("-------------------------------");
        SalaryInfo salaryInfo=new SalaryInfo(employeeInfo.EmployeeID,employeeInfo.Name,employeeInfo.FatherName,employeeInfo.Phone,employeeInfo.Gender,24);
        personalInfo=salaryInfo;
        personalInfo.Display();
    }
}
