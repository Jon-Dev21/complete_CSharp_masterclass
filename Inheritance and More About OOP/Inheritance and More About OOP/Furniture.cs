using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    /// <summary>
    /// Furniture class.
    /// Created in the "Creating and using your own Interfaces" course section.
    /// </summary>
    class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        // Default constructor
        public Furniture()
        {
            Color = "White";
            Material = "Wool";
        }

        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
