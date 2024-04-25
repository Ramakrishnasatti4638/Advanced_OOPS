using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    public partial class PersonalDetails
    {
        //Method class 
        // public int CalculateAge()
        // {
        //     TimeSpan span=DateTime.Now-DOB;
        //     return span.Days/365;
        // }

        //Method class- List
        public partial int CalculateAge();

    }
}