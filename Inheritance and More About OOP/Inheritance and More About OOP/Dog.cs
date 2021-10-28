using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    // Class used to demonstrate Override keyword
    class Dog : Animal
    {
        // Property to check if the dog is Happy.
        public bool IsHappy { get; set; }

        // Simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age, bool isHungry) : base(name,age, isHungry)
        {
            // All dogs are happy :D
            IsHappy = true;
        }

        // Simple override of the virtual method Eat. override keyword used when overriding 
        public override void Eat()
        {
            // To call a method from our base class, we use the keyword "base"
            base.Eat();
        }

        // override of the virtual method MakeSound
        public override void MakeSound()
        {
            // Since every animal makes different sounds, we will override this method.
            Console.WriteLine("Wooof wooof!!");
        }

        public override void Play()
        {
            // If the dog is happy, it will play. Else it will not play.
            if(IsHappy)
                base.Play();
            else
                Console.WriteLine("{0} is not happy. {0} doesn't want to play.", Name);
        }


    }
}
