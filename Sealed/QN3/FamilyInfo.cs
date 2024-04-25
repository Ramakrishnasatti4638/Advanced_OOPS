using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN3
{
    public class FamilyInfo:PersonalInfo
    {
        //Properties: FatherName, MotherName, NoOfSiblings, NativePlace
        //public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int NoOfSiblings { get; set; }
        public string NativePlace { get; set; }

        public FamilyInfo(string name,string fatherName,string mobile,string mail,Gender gender,string motherName,int noOfSiblings,string nativePlace):base( name, fatherName, mobile, mail, gender)
        {
            //FatherName=fatherName;
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            NativePlace=nativePlace;
        }

        //Method: Sealed override Update, DisplayInfo
        public sealed override void Update(string name,string fatherName,string mobile,string mail,Gender gender)
        {
            base.Update(name,fatherName,mobile,mail,gender);
        }

        public sealed override void DisplayInfo()
        {
            base.DisplayInfo();
            System.Console.WriteLine($"Mother Name: {MotherName}\nNo of siblings: {NoOfSiblings}\nNative Place: {NativePlace}");
            
        }
    }
}