using System;
namespace QN2;
class Program 
{
    public static void Main(string[] args)
    {
        ShiftDzire shiftDzire=new ShiftDzire(FuleType.Petrol,5,"red",50,750.00,"eig1001","cha1001","Swift","Dzire");
        shiftDzire.ShowDetails();

        System.Console.WriteLine("-------------------------------------");
        Eco eco=new Eco(FuleType.Diesel,5,"blue",30,7500.00,"eig1002","cha1002","Swift","Eco");
        eco.ShowDetails();
    }
}