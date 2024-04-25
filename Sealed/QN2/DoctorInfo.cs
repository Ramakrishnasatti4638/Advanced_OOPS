using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class DoctorInfo //PatientInfo //Error
    {
        private static int s_doctorID=100;
        //Properties: DoctorID, Name, FatherName
        public string DoctorID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        // public DoctorInfo(string name1,string fatherName1,int bedNo,string nativePlace,string admittedFor,string name,string fatherName):base( name1, fatherName1, bedNo, nativePlace, admittedFor)
        // {
        //     s_doctorID++;
        //     DoctorID="DID"+s_doctorID;
        //     Name=name;
        //     FatherName=fatherName;
        // }

        //Methods: DisplayInfo
        // public void DisplayInfo()
        // {
        //     Console.WriteLine($"PatientID: {PatientID}\nName: {Name}\nFather Name: {FatherName}\nBed No: {BedNo}\nNative Place: {NativePlace}\nAdmitted For: {AdmittedFor}");
            
        // }
    }
}