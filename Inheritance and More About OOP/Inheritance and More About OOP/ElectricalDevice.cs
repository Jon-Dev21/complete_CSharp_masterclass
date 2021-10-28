using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    // Base class - Parent Class (Used to demonstrate Inheritance)
    class ElectricalDevice
    {
        // Boolean to determine the state of the electrical device.
        public bool IsOn { get; set; }
        // string for the brand name of the electrical device
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        // Switch on the Electrical Device
        public void SwitchOn()
        {
            IsOn = true;
        }

        // Switch off the Electrical Device
        public void SwitchOff()
        {
            IsOn = false;
        }

    }
}
