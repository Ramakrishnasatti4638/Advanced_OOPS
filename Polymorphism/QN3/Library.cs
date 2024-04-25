using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN3
{
    public abstract class Library
    {
        // Field : serial number -LIB1000
        private static int s_serialNumber=1000;

        // Property : serial number
        public string SerialNumber { get; set; }    

        // Abstract properties:, author name, book name, publisher name, year
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }

        public Library()
        {
            s_serialNumber++;
            SerialNumber="LIB"+s_serialNumber;
            
        }
        // Abstract methods: set book info, display info
        public abstract void SetBookInfo();
        public abstract void DisplayInfo();

    }
}