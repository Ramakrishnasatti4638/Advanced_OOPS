using System;
namespace QN1;
public class Program 
{
    public static void Main(string[] args)
    {
        Shape cylinder=new Cylinder();
        cylinder.Radius=2;
        cylinder.Height=2;
        cylinder.Width=2;
        Shape cube=new Cubes();
        cube.Page=2;
        Console.WriteLine($"Area of cylinder: {cylinder.CalculateArea()}");
        Console.WriteLine($"Volume of cylinder: {cylinder.CalculateVolume()}");
        Console.WriteLine($"Area of cube: {cube.CalculateArea()}");
        Console.WriteLine($"Volume of cube: {cube.CalculateVolume()}");
    }
}