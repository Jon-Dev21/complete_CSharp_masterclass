using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymortphism_And_Even_more_on_OOP
{
    class Audi : Car
    {
        public string Model { get; set; }
        private string Brand = "Audi";

        public Audi(float hp, string color, string model):base(hp,color)
        {
            Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Brand: {0}\nModel: {1}\nHorse Power: {2}\nColor: {3}", Brand, Model, HorsePower, Color);
        }

        public override void RepairCar()
        {
            Console.WriteLine("The {0} {1} was repaired!", Brand, Model);
        }
    }
}
