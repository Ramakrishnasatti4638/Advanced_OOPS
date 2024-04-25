using System;
namespace MultiLeveInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails person = new PersonalDetails("Ramakrishna", "MuraliKrishna", Gender.Male, "9441882121");
        System.Console.WriteLine($"User ID: {person.UserID}\nName : {person.Name}\nFather Name : {person.FatherName}\nGender : {person.Gender}\nMobile Number : {person.MobileNumber}");

        StudentDetails student = new StudentDetails(person.UserID, person.Name, person.FatherName, person.Gender, person.MobileNumber, 1, "2012");
        EmployeeDetails employee = new EmployeeDetails(student.StudentID, student.UserID, student.Name, student.FatherName, student.Gender, student.MobileNumber, student.Standard, student.YearOfJoining, "student");
    }
}