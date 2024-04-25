using System;
namespace QN1;
public class Program 
{
    public static void Main(string[] args)

    {
        //PersonalInfo personal=new PersonalInfo();

        HSCDetails hSCDetails=new HSCDetails("Ramakrishna","muralikrishna","9874563210","sa@gmail.com",new DateTime(2002,03,21),Gender.Male,12,"MPC","2019",96,96,91);
        hSCDetails.ShowInfo();
        hSCDetails.ShowMarkSheet();

        HSCDetails hSCDetails1=new HSCDetails("Thanuja","muralikrishna","123654789","paaa@gmail.com",new DateTime(2000,05,17),Gender.Female,10,"Science","2017",100,96,65);
        hSCDetails1.ShowInfo();
        hSCDetails1.ShowMarkSheet();
    }
}