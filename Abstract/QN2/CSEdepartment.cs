using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class CSEdepartment:Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override string Year { get; set; }

        public override void SetBookInfo()
        {
            Console.WriteLine("Enter Author name: ");
            AuthorName=Console.ReadLine();
            Console.WriteLine("Enter book name: ");
            BookName=Console.ReadLine();
            Console.WriteLine("Enter publisher name: ");
            PublisherName=Console.ReadLine();
            Console.WriteLine("Enter year: ");
            Year=Console.ReadLine();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Serial Number: "+SerialNumber);
            Console.WriteLine("Author name: "+AuthorName);
            Console.WriteLine("Book name: "+BookName);
            Console.WriteLine("Publisher name: "+PublisherName);
            Console.WriteLine("Published year: "+Year);
        }
    }
}