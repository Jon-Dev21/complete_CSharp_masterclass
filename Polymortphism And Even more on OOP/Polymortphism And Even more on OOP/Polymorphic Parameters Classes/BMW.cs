using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymortphism_And_Even_more_on_OOP
{
    class BMW : Car
    {
        public string Model { get; set; }
        private string Brand = "BMW";

        public BMW() {}

        public BMW(float hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }
        /// <summary>
        /// Using new keyword to hide base class member method.
        /// Override keyword was replaced with new. (It's not overriding it. It's re prioritizing it.
        /// </summary>
        public new void ShowDetails()
        {
            Console.WriteLine("Brand: {0}\nModel: {1}\nHorse Power: {2}\nColor: {3}", Brand, Model, HorsePower, Color);
        }


        // Adding sealed keyword so that this method can't be override.
        // The method needs to have override keyword in order to use sealed keyword.
        public sealed override void RepairCar()
        {
            Console.WriteLine("The {0} {1} was repaired!", Brand, Model);
        }
    }
}
