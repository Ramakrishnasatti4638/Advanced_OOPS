using System;
using AbstractClassesAndMethods;
namespace AbstarctClassesAndMethods;
class Program 
{
    public static void Main(string[] args)
    {
        Employee job1=new Syncfusion();
        job1.Name="Ramakrishna";
        System.Console.WriteLine(job1.Display());
        System.Console.WriteLine(job1.Salary(30));

        Employee job2=new Syncfusion();
        job2.Name="Ramakrishna";
        System.Console.WriteLine(job2.Display());
        System.Console.WriteLine(job2.Salary(30));
    }
}