using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diernasiel
{
    class Reservation
    { 
        public Cat Cat { get; private set; } 
        public Dog Dog { get; private set; }

        public void NewCat(string name, Gender gender, string badHabits)
        {
            Cat c = new Cat();
            c.Name = name;
            c.Gender = gender; 
            c.BadHabits = badHabits;
        }

        public void NewDog(string name, Gender gender)
        {
            Dog d = new Dog();
            d.Name = name;
            d.Gender = gender;
        }
    }
}
