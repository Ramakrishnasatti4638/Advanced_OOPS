using System;
namespace QN1;
public class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Ramakrishna","muralikrishna",new DateTime(2002,03,21),"987456321",Gender.Male,"satti@gmail.com");
        Teacher teacher=new Teacher(personal.Name,personal.FatherName,personal.DOB,personal.Phone,personal.Gender,personal.Mail,"Teaching",Subject.Maths,"PHD",5,new DateTime(2019,02,12));
        StudentInfo student=new StudentInfo(personal.Name,personal.FatherName,personal.DOB,personal.Phone,personal.Gender,personal.Mail,"B.Tech",Department.CSE,6);
        PrincipalInfo principal=new PrincipalInfo(personal.Name,personal.FatherName,personal.DOB,personal.Phone,personal.Gender,personal.Mail,"BCD",12,new DateTime(2019,02,12));
        teacher.ShowDetails();
        System.Console.WriteLine("------------------------------------------");
        student.ShowDetails();
        System.Console.WriteLine("------------------------------------------");
        principal.ShowDetails();
    }
}