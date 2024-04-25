using System;
using System.IO;
using System.Linq;
namespace FileFolder;
class Program 
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\SattiVenkataRamaKris\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath=path+"/Ramakrishna";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Creating Folder....");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            System.Console.WriteLine("Folder already exists");
        }
        string filePath=path+"/myFile.txt";
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("Creating file....");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("File already exists.");
        }

        System.Console.WriteLine("Select\n1. Create Folder\n2.Create file\n3. Delete Folder\n4. Delete file");
        int option=int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
            {
                System.Console.WriteLine("Enter folder name you want to create");
                string folder=Console.ReadLine();
                string newPath=path+"/"+folder;
                if(!Directory.Exists(newPath))
                {
                    System.Console.WriteLine("Creating folder "+folder);
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    System.Console.WriteLine("Folder already exists");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter the file name you want to create");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter file extension");
                string extension=Console.ReadLine();
                string newFilePath=path+"/"+fileName+"."+extension;
                if(!File.Exists(newFilePath))
                {
                    System.Console.WriteLine("Creating file "+fileName+"."+extension);
                    File.Create(newFilePath);
                }
                else
                {
                    System.Console.WriteLine("File already exists");
                }
                break;
            }
            case 3:
            {
                foreach(string path1 in Directory.GetDirectories(path))
                {
                    System.Console.WriteLine(path1);
                }
                System.Console.WriteLine("Select the folder you want to remove");
                string folder1=Console.ReadLine();
                foreach(string path1 in Directory.GetDirectories(path))
                {
                    string[] list=path1.Split('\\');
                    if(list[list.Length-1].Equals(folder1))
                    {
                        System.Console.WriteLine("Deleting the folder "+folder1);
                        Directory.Delete(path1);
                        
                    }
                }
                break;
            }
            case 4:
            {
                foreach(string file1 in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(file1);
                }
                System.Console.WriteLine("Enter thge file name you want to delete");
                string file1Name=Console.ReadLine();
                foreach(string file1 in Directory.GetFiles(path))
                {
                    string[] list=file1.Split('\\');
                    if(list[list.Length-1].Equals(file1Name))
                    {
                        System.Console.WriteLine("Deleting the file "+file1Name);
                        File.Delete(file1);
                    }
                   

                }
                break;
            }
        }
    }
}