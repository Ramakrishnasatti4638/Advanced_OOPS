using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public abstract class Library
    {
        //Field : serial number -LIB1000
        private static int s_serialNumber=1000;

        //Property : SerialNumber
        public string SerialNumber { get; set; }
        //Abstract properties:, AuthorName, BookName, PublisherName, Year
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract string Year { get; set; }

        public Library()
        {
            s_serialNumber++;
            SerialNumber="LIB"+s_serialNumber;
        }
        //Abstract methods: SetBookInfo, DisplayInfo

        public abstract void SetBookInfo();
        public abstract void DisplayInfo();
    }
}