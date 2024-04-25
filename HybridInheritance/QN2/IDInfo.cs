using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public class IDInfo:PersonalInfo
    {
        private static int s_voterID=10000;
        //Properties: VoterID, AadharID, PAN number
        public string VoterID { get; set; } 
        public string AadharID { get; set; }
        public string PanNumber { get; set; }

        public IDInfo(string name,Gender gender,DateTime dob,string phone,string aadharID,string panNumber):base( name, gender, dob, phone)
        {
            s_voterID++;
            VoterID="VID"+s_voterID;
            AadharID=aadharID;
            PanNumber=panNumber;
        }
        public IDInfo(string voterID,string name,Gender gender,DateTime dob,string phone,string aadharID,string panNumber):base( name, gender, dob, phone)
        {
           
            VoterID=voterID;
            AadharID=aadharID;
            PanNumber=panNumber;
        }
    }
}