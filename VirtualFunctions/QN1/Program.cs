using System;
using System.Threading;
namespace QN1;
public class Program 
{
    public static void Main(string[] args)
    {
        AreaCalculator area=new AreaCalculator(5);
        VoulmeCalculator voulme=new VoulmeCalculator(area.Radius,10);
        area.Calculate();
        area.Display();
        voulme.Calculate();
        voulme.Display();
    }
}