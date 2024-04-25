using System;
using System.IO;
using System.Runtime.Intrinsics.Arm;
namespace ReadWriteTXT;
class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            System.Console.WriteLine("Creating an folder..");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            System.Console.WriteLine("Folder already exists");
        }
        if(!File.Exists("TestFolder/MyFile.txt"))
        {
            System.Console.WriteLine("Creating file...");
            File.Create("TestFolder/MyFile.txt").Close();
        }
        else
        {
            System.Console.WriteLine("File existed");
        }
        System.Console.WriteLine("Select\n1. Read from file\n2. Write from file");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                StreamReader sr=new StreamReader("TestFolder/MyFile.txt");
                string data=sr.ReadLine();
                while(data!=null)
                {
                    System.Console.WriteLine(data);
                    data=sr.ReadLine();
                }
                sr.Close();
                break;
            }
            case 2:
            {
                string[] contents=File.ReadAllLines("TestFolder/MyFile.txt");
                StreamWriter sw=new StreamWriter("TestFolder/MyFile.txt");
                System.Console.WriteLine("Enter what do you want to place in file");
                string data=Console.ReadLine();
                string old=""; 
                foreach(string line in contents)
                {
                    old+=line+"\n";
                }
                old+=data+"\n";
                sw.WriteLine(old);
                sw.Close();
                break;
            }
        }
    }
}