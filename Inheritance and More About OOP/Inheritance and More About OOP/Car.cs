using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    /// <summary>
    /// Car class. Inherits from base class Vehicle.
    /// Created in the "Creating and using your own Interfaces" course section.
    /// </summary>
    class Car : Vehicle, IDestroyable
    {
        // Implementing the interface's property
        public string DestructionSound { get; set; }

        // Creating a new property to store the destroyable objects nearby.
        // When a car gets destroyed, it should also destroy the nearby objects.
        // This list is of type IDestroyable which means it can store any object
        // That implements this interface and we can only acces the properties and 
        // methods in this interface.
        public List<IDestroyable> DestroyablesNearby = new List<IDestroyable>();

        // simple constructor
        public Car(float speed, string color):base(speed,color) 
        {
            DestructionSound = "CarDestructionSound.mp3";
        }


        public void Destroy()
        {
            // When a car gets destroyed we should play the destruction sound
            // and create a fire effect.
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Creating fire effect.");

            // Go through each destroyable object nearby and call it's destroy method.
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
