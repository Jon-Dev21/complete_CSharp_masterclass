using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymortphism_And_Even_more_on_OOP.Abstract
{
    class Cube : Shape
    {
        /// <summary>
        /// Length of the cube.
        /// </summary>
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }

        /// <summary>
        /// Implemented abstract class method.
        /// </summary>
        /// <returns></returns>
        public override double Volume()
        {
            // Return length to the power of 3.
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("This {0} has a length of {1}", Name, Length);
        }
    }
}
