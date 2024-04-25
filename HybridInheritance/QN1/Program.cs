using System;
using System.Collections.Generic;
namespace QN1;
class Program 
{
    public static void Main(string[] args)
    {
        MarkSheet markSheet=new MarkSheet("Ramakrishna","Muralikrishna","9874563210",DateTime.Now,Gender.Male,new List<double>(){87,78,96,78,54,89},new List<double>(){87,78,96,78,54,89},new List<double>(){87,78,96,78,54,89},new List<double>(){87,78,96,78,54,89},DateTime.Now,100);
        markSheet.SHowUGMarkSHeet();

        MarkSheet markSheet1=new MarkSheet("Thanuja","Muralikrishna","1236547890",DateTime.Now,Gender.Female,new List<double>(){87,78,96,78,84,12},new List<double>(){87,78,96,78,54,89},new List<double>(){87,78,45,78,54,89},new List<double>(){87,78,78,78,54,89},DateTime.Now,45);
        markSheet1.SHowUGMarkSHeet();
    }
}