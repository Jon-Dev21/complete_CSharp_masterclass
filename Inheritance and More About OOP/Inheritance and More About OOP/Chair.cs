using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    /// <summary>
    /// Chair class. Inherits from base class Furniture.
    /// Created in the "Creating and using your own Interfaces" course section.
    /// </summary>
    class Chair : Furniture, IDestroyable
    {
        // Implementing the interface's property
        public string DestructionSound { get; set; }

        public Chair(string color, string material) : base(color, material) 
        {
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            // When a chair gets destroyed we should play the destruction sound
            // and spawn destroyed chair parts.
            Console.WriteLine("The {0} chair was destroyed", Color);
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning destroyed chair parts.");
        }
    }
}
