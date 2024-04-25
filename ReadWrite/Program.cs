using System;
using System.IO;
using System.Collections.Generic;
namespace ReadWrite;
class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            System.Console.WriteLine("Creating folder...");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            System.Console.WriteLine("Directory exists");
        }

        if(!File.Exists("TestFolder/Data.csv"))
        {
            System.Console.WriteLine("Creating file.......");
            File.Create("TestFolder/Data.csv");
        }
        else
        {
            System.Console.WriteLine("File already exists");
        }

        List<StudentDetails> studentList=new List<StudentDetails>();
        studentList.Add(new StudentDetails(){Name="Ramakrishna",FatherName="Muralikrishna",Gender=Gender.Male,DOB=new DateTime(2002,02,21),TotalMark=400});
        studentList.Add(new StudentDetails(){Name="Thanuja",FatherName="Murali",Gender=Gender.Female,DOB=new DateTime(2000,05,17),TotalMark=500});
        studentList.Add(new StudentDetails(){Name="Mummy",FatherName="Dady",Gender=Gender.Male,DOB=new DateTime(2002,06,21),TotalMark=300});
        WriteToCSV(studentList);
        ReadCSV();
    }
    static void WriteToCSV(List<StudentDetails> studentList)
    {
        StreamWriter sw=new StreamWriter("TestFolder/Data.csv");
        foreach(StudentDetails student in studentList)
        {
            string line=student.Name+","+student.FatherName+","+student.Gender+","+student.DOB.ToString("dd/MM/yyyy")+","+student.TotalMark;
            sw.WriteLine(line);
        }
        sw.Close();
    }

    static void ReadCSV()
    {
        List<StudentDetails> newList=new List<StudentDetails>();
        StreamReader sr=new StreamReader("TestFolder/Data.csv");
        string line=sr.ReadLine();
        while(line!=null)
        {
            string[] values=line.Split(",");
            if(values[0]!=null)
            {
                StudentDetails student=new StudentDetails()
                {
                    Name=values[0],
                    FatherName=values[1],
                    Gender=Enum.Parse<Gender>(values[2]),
                    DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null),
                    TotalMark=int.Parse(values[4])

                };
                newList.Add(student);
                
            }
            line=sr.ReadLine();
        }
        sr.Close();
        foreach(StudentDetails student in newList)
        {
            System.Console.WriteLine("Name:"+student.Name);
            System.Console.WriteLine("FatherName:"+student.FatherName);
            System.Console.WriteLine("Gender:"+student.Gender);
            System.Console.WriteLine("DOB:"+student.DOB.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Total Marks:"+student.TotalMark);

        }
    }
}