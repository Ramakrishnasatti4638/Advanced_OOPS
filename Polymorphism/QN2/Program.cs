using System;
namespace QN2;
class Program 
{
    public static void Main(string[] args)
    {
        Square(10);
        Square(10.1f);
        Square(10.1);
        Square(10001122553535);

    }

    public static void Square(int number)
    {
        System.Console.WriteLine(number*number);
    }
    public static void Square(float number)
    {
        System.Console.WriteLine(number*number);
    }
    public static void Square(double number)
    {
        System.Console.WriteLine(number*number);
    }
    public static void Square(long number)
    {
        System.Console.WriteLine(number*number);
    }
}