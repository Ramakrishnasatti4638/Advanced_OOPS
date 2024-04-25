using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class BookInfo:RackInfo
    {
        private static int s_bookID=100;
        //Properties: BookID, BookName, AuthorName, Price
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }  
        public double Price { get; set; }

        public BookInfo(string departmentName,string degree,int rackNumber,int coulumnNumber,string bookName,string authorName,double price):base(departmentName,degree,rackNumber,coulumnNumber)
        {
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Department Name: {DepartmentName}\nDegree: {Degree}\nRack Number: {RackNumber}\nColumn Number: {ColumnNumber}\nBook Nmae: {BookName}\nAuthor Name: {AuthorName}\nPrice: {Price}");
        }

    }
}