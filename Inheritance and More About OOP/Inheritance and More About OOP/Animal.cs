using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    // Class used to demonstrate use of virtual keyword
    class Animal
    {
        // Animal Name
        public string Name { get; set; }
        // Animal Age
        public int Age { get; set; }
        // Is animal Hungry
        public bool IsHungry { get; set; }

        // Animal constructor
        public Animal(string name, int age, bool isHungry)
        {
            this.Name = name;
            this.Age = age;
            this.IsHungry = isHungry;
        }

        // Make sound (Using virtual to enable method overriding in child classes)
        public virtual void MakeSound()
        {
            Console.WriteLine("Making {0} Sounds!", Name);
        }

        // Eat
        public virtual void Eat()
        {
            // Check if animal is hungry
            if(IsHungry)
                Console.WriteLine("{0} is Eating!", Name);
            else
                Console.WriteLine("{0} is not hungry.", Name);
        }

        // Play
        public virtual void Play()
        {
            Console.WriteLine("{0} is Playing!", Name);
        }
    }
}
