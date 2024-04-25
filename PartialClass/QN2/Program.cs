using System;
namespace QN2;
public class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Ramakrishna",Gender.Male,new DateTime(2002,03,21),"9441882121",95,95,95);
        student.CalculateTotal();
        student.CalculatePercentage();
        System.Console.WriteLine("-------------------------------------------------------------");
        StudentInfo student1=new StudentInfo("Thanuja",Gender.Female,new DateTime(2000,05,15),"9492245872",98,45,78);
        student1.CalculateTotal();
        student1.CalculatePercentage();
        
        
    }
}