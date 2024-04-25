using System;
namespace QN2;
public class Program 
{
    public static void Main(string[] args)
    {
        DepartmentDetails department=new DepartmentDetails("CSE","B.Tech");
        RackInfo rack=new RackInfo(department.DepartmentName,department.Degree,12,45);
        BookInfo book=new BookInfo(rack.DepartmentName,rack.Degree,rack.RackNumber,rack.ColumnNumber,"RICH DAD","RAMAKRISHNA",2000);
        book.DisplayInfo();
    }
}