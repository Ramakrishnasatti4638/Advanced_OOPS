using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public class Dog:IAnimal
    {
        private string _name,_habitat,_eatingHabit;
        public string Name{get{return _name;}set{_name = value;}}
        public string Habitat{get{return _habitat;} set{_habitat=value;}}
        public string EatingHabit{get{return _eatingHabit;}set{_eatingHabit=value;}}

        public void DisplayName()
        {
            System.Console.WriteLine(Name);
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("Habitat: "+Habitat);
            System.Console.WriteLine("Eating Habit: "+EatingHabit);
        }
    }
}