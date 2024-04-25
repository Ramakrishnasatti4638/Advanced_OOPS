using System;
namespace QN1;
class Program 
{
    public static void Main(string[] args)
    {
        RegisterPerson registerPerson=new RegisterPerson(DateTime.Now)
        {
            Name="Ramakrishna",
            Gender=Gender.Male,
            Phone="98745631",
            MaritalStatus=MaritalStatus.Single,
            FatherName="Muralikrishna",
            MotherName="Anathalakshmi",
            HouseAddress="Tadepalligudem",
            NoOfSiblings=2
        };
        registerPerson.ShowInfo();
        System.Console.WriteLine("-------------------------------------------------");
        RegisterPerson registerPerson1=new RegisterPerson(DateTime.Now)
        {
            Name="Thanuja",
            Gender=Gender.Female,
            MaritalStatus=MaritalStatus.Married,
            FatherName="Muralikrishna",
            MotherName="Anathalakshmi",
            HouseAddress="California",
            NoOfSiblings=2
        };
        registerPerson1.ShowInfo();
    }
}