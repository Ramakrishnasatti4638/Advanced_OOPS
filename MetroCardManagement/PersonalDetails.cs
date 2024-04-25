using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// Class PersonalDetails used to create the instace of <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        //  Properties:
        // •	UserName
        // •	Phone Number

        /// <summary>
        /// Property UserName is used to hold the name of user <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }

        /// <summary>
        /// Property PhoneNumber used to hold the phonenumber of the user <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Parametrrized constructor used to assign values to the properties <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        public PersonalDetails(string name, string phone)
        {
            UserName = name;
            PhoneNumber = phone;
        }

        /// <summary>
        /// Construtor used to assign values to the properties from the file <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="user"></param> <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public PersonalDetails(string user)
        {
            string[] values = user.Split(",");
            UserName = values[1];
            PhoneNumber = values[2];
        }

        public PersonalDetails()
        {
            
        }
    }
}