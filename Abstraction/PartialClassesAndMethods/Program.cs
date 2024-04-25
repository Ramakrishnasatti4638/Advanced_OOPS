using System;
using System.ComponentModel.DataAnnotations;
namespace PartialClassesAndMethods;
public class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails person=new PersonalDetails();
        person.DOB=new DateTime(2002,03,21);
        System.Console.WriteLine(person.CalculateAge());
        
    }
}