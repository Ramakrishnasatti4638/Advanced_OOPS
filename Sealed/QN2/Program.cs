using System;
namespace QN2;
public class Program 
{
    public static void Main(string[] args)
    {
        PatientInfo patient=new PatientInfo("Rama","murali",5,"tade","vomit");
        patient.DisplayInfo();
        //DoctorInfo doctor=new DoctorInfo(patient.Name,patient.FatherName,patient.BedNo,patient.NativePlace,patient.AdmittedFor,"Nidu","telu");
        PatientInfo patient1=new PatientInfo("krishna","reddy",10,"gudem","headache");
        patient1.DisplayInfo();
    }
}