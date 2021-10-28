using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    // Child class of Electrical Device (Used to demonstrate Inheritance)
    class TV : ElectricalDevice
    {
        // This constructor uses the base class constructor
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }


        // method to watch the TV.
        public void WatchTV()
        {
            // Check if the TV is on.
            if (IsOn)
            {
                // Watch TV
                Console.WriteLine("Watching the TV!");
            }
            else
            {
                // Print Error Message
                Console.WriteLine("TV is switched off, switch it on first.");
            }
        }
    }
}
