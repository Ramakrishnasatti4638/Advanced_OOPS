using System;
namespace QN3;
public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Maruthi swift");
        MaruthiSwift maruthiSwift= new MaruthiSwift();
        maruthiSwift.GetEngineType();
        maruthiSwift.GetNoOfSeats();
        maruthiSwift.GetPrice();
        maruthiSwift.GetCarType();
        maruthiSwift.DisplayCarDetails();

        Console.WriteLine("Suzuki Ciaz");
        SuzukiCiaz suzukiCiaz=new SuzukiCiaz();
        suzukiCiaz.GetEngineType();
        suzukiCiaz.GetNoOfSeats();
        suzukiCiaz.GetPrice();
        suzukiCiaz.GetCarType();
        suzukiCiaz.DisplayCarDetails();

    }
}