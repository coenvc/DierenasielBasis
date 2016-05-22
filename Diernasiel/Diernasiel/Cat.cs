using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diernasiel
{
    class Cat
    {
        public string Name;
        public Gender Gender;
        public string BadHabits;

        public bool Reserve(Reservor name)
        {
            return true; 
        }

        public override string ToString()
        {
            return "De kat heet : " + Name + " Het is een " + Gender + " Enz zijn / haar slecht eigenschappen zijn: "+ BadHabits;
        }
    }
}
