using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymortphism_And_Even_more_on_OOP.Abstract
{
    // Abstract class shape
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("This is a {0}", Name);
        }

        /// <summary>
        /// This method is not implemented here, but in the class that inherits from
        /// this class, Shape.
        /// </summary>
        /// <returns></returns>
        public abstract double Volume();
    }
}
