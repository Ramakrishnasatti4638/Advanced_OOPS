using System;
namespace QN1;
class Program 
{
    public static void Main(string[] args)
    {
        Multiply(10);
        Multiply(10,20);
        Multiply(10,20,30);
        Multiply(10,20.12);
        Multiply(10,20.1222222,11);
    }

    public static void Multiply(int number1)
    {
        System.Console.WriteLine(number1*number1);

    }
    public static void Multiply(int number1,int number2)
    {
        System.Console.WriteLine(number1*number2);

    }
    public static void Multiply(int number1,int number2,int number3)
    {
        System.Console.WriteLine(number1*number2*number3);

    }
    public static void Multiply(int number1,double number2)
    {
        System.Console.WriteLine(number1*number2);

    }
    public static void Multiply(int number1,double number2,float number3)
    {
        System.Console.WriteLine(number1*number2*number3);

    }
}