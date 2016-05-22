using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diernasiel
{
    public enum Gender
    {
        Male, 
        Female
    }
    class Dog
    {
        public string Name;
        public Gender Gender;
        public DateTime LastWalk;

        public override string ToString()
        {
            return "De kat heet : " + Name + " Het is een " + Gender + " Hij/zij is het laatst uitgelaten op: " + LastWalk;
        }

    }
}
