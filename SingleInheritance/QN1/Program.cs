using System;
namespace QN1;
public class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Ramakrishna","MuraliKrishna","9441882121","satti@gmail.com",new DateTime(2002,03,21),Gender.Male);
        StudentInfo student=new StudentInfo(personal.Name,personal.FatherName,personal.Phone,personal.Mail,personal.DOB,personal.Gender,11,"MPC","2019");
        student.showStudentInfo();
        Console.WriteLine();

        PersonalInfo personal1=new PersonalInfo("Nandu","krishna","9441882","satti@gmail.com",new DateTime(2014,08,21),Gender.Female);
        StudentInfo student1=new StudentInfo(personal1.Name,personal1.FatherName,personal1.Phone,personal1.Mail,personal1.DOB,personal1.Gender,10,"MPC","2016");
        student1.showStudentInfo();
    }
}