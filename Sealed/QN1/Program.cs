using System;
namespace QN1;
public class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Ramakrishna","MuraliKrishna","9441223654","sa@gmail.com",Gender.Male);
        EmployeeInfo employee=new EmployeeInfo("ramki123","rama21211");
        employee.DisplayInfo();

        // Hack hack=new Hack(employee.UserID,employee.Password); error

    }
}