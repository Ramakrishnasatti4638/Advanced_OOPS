using System;
namespace QN1;
public class Program 
{
    public static void Main(string[] args)
    {
        Dog dog1=new Dog();
        dog1.Name="Uday";
        dog1.Habitat="Roaming";
        dog1.EatingHabit="carnivorous";
        Dog dog2=new Dog();
        dog2.Name="Lokesh";
        Duck duck1=new Duck();
        duck1.Name="Thanuja";
        Duck duck2=new Duck();
        duck2.Name="Rama";

        dog1.DisplayName();

        dog2.DisplayName();
        duck1.DisplayName();
        duck2.DisplayName();

        dog1.DisplayInfo();
        dog2.DisplayInfo();
        duck1.DisplayInfo();
        duck2.DisplayInfo();
        
    }
}