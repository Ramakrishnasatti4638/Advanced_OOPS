using System;
namespace QN2;
public class Program 
{
    public static void Main(string[] args)
    {
        Rectangle rectangle=new Rectangle(2,2);
        Sphere sphere=new Sphere(5);
        rectangle.Calculate();
        rectangle.Display();
        sphere.Calculate();
        sphere.Display();
    }
}