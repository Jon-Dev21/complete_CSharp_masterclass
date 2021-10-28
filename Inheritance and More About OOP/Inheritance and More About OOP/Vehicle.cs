using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    /// <summary>
    /// Vehicle class.
    /// Created in the "Creating and using your own Interfaces" course section.
    /// </summary>
    class Vehicle
    {

        public float Speed { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {
            Speed = 120f;
            Color = "Black";
        }

        // simple constructor
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }

    }
}
