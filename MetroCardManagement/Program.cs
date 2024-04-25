using System;
namespace MetroCardManagement;
class Program
{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        FileHandling.ReadFromCSV();
        //Operations.DefaultValues();
        Operations.MainMenu();
        FileHandling.WriteToCSV();
    }
}