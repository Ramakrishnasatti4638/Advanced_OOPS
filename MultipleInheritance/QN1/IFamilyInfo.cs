using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public interface IFamilyInfo:IShowData
    {
        //Properties: FatherName, MotherName, HouseAddress, No.Of.Siblings  
        public string   FatherName     { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }

        //public void ShowInfo();
    }
}