using System;
namespace Interface;
public class Program 
{
    public static void Main(string[] args)
    {
        Square number=new Square(); //class vriable as object
        number.Number=20;
        System.Console.WriteLine(number.Calculate());

        Circle newNumber=new Circle();
        newNumber.Number=5;
        System.Console.WriteLine(newNumber.Calculate());
    }
}