using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class RegisterPerson:PersonalInfo,IShowData,IFamilyInfo
    {
        private static int s_registrationNumber=1000;
        //Properties: RegistrationNumber(Auto), DateOfRegistration,
        public string RegistrationNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }

        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }

        public RegisterPerson(DateTime dateOfRegistration)
        {
            s_registrationNumber++;
            RegistrationNumber="RID"+s_registrationNumber;
            DateOfRegistration=dateOfRegistration;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine($"Registration Number: {RegistrationNumber}\nDOR: {DateOfRegistration}");
            base.ShowInfo();
            System.Console.WriteLine($"Father name: {FatherName}\nMother nmae: {MotherName}\nHouse address: {HouseAddress}\nNo of siblings: {NoOfSiblings}");
            
        }

    }
}