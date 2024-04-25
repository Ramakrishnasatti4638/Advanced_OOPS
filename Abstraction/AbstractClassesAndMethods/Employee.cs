using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee   //Abstract class
    {
        //Abstract class - partial abstraction.
        //I has fields,property, methods, constructor, destructor, indexers, events.
        //Can have both abstract declaration and normal definitions
        //Can only used with an inherited class
        //Not support multiple inheritance
        //It cannot be static class
        protected string _name;   //Normal fields

        public abstract string Name { get; set; }  //Abstract property
        public double Amount { get; set; } //Normal property

        public string Display() //Normal method
        {
            return _name;
        }

        public abstract double Salary(int dates);    //Abstract method - Only declaration


    }
}