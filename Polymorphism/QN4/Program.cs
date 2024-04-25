using System;
namespace QN4;
class Program 
{
    public static void Main(string[] args)
    {
        Syncfusion syncfusion=new Syncfusion("Ramrkishna","murali",Gender.Male,"B.Tech","SD",24,"Chennai");
        syncfusion.DisplayInfo();

        System.Console.WriteLine("-----------------------------------");
        Syncfusion syncfusion1=new Syncfusion("Thanuja","murali",Gender.Female,"P.hD","Engineer",20,"Hyderabad");
        syncfusion1.DisplayInfo();
    }
}