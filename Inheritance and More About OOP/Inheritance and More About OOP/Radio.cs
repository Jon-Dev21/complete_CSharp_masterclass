using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    // Child class of Electrical Device (Used to demonstrate Inheritance)
    class Radio : ElectricalDevice
    {
        // Base keyword uses the base class constructor
        public Radio (bool isOn, string brand):base(isOn,brand)
        {
        }
        
        // method to listen to the radio.
        public void ListenRadio()
        {
            // Check if the radio is on.
            if(IsOn)
            {
                // Listen to radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                // Print Error Message
                Console.WriteLine("Radio is switched off, switch it on first.");
            }
        }


    }
}
