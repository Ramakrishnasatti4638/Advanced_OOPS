using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN2
{
    public interface IBrand
    {
        //Property: BrandName, ModelName
        public string BrandName { get; set; }
        public string ModelName { get; set; }   


        //Method: Show Details
        public void ShowDetails();


    }
}