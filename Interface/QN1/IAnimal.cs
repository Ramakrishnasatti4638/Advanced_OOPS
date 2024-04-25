using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN1
{
    public interface IAnimal
    {
        // Name, Habitat, Eating Habit
        string Name{get; set;}
        string Habitat{get; set;}
        string EatingHabit{get; set;}
        
        //DisplayName
        void DisplayName();
    }
}