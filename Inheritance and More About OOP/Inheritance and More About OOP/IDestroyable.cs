using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    interface IDestroyable
    {
        // Property to store the audio file of the destruction sound.
        string DestructionSound { get; set; }

        // Method to destroy and Object.
        void Destroy();
    }
}
