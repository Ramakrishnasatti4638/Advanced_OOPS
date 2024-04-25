using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public sealed class PatientInfo
    {
        private static int s_patientID=1000;
        //Properties: PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor
        public string PatientID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }  
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }

        public PatientInfo(string name,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            s_patientID++;
            PatientID="PID"+s_patientID;
            Name=name;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=nativePlace;
            AdmittedFor=admittedFor;
        }

        //Method: DisplayInfo
        public void DisplayInfo()
        {
            Console.WriteLine($"PatientID: {PatientID}\nName: {Name}\nFather Name: {FatherName}\nBed No: {BedNo}\nNative Place: {NativePlace}\nAdmitted For: {AdmittedFor}");
            
        }
    }
}