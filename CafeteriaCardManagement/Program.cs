using System;
using CafeteriaCardManagement;
namespace CafeteriaCradManagement;
class Program 
{
    public static void Main(string[] args)
    {

        //FileHandling.Create();
        FileHandling.ReadFromCSV();
        //Operations.DefaultValues();
        Operations.MainMenu();
        FileHandling.WriteToCSV();
    }
}