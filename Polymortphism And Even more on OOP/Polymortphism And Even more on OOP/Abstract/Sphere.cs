using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymortphism_And_Even_more_on_OOP.Abstract
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume()
        {
            return (4 / 3) * (Math.PI * Math.Pow(Radius, 3));
        }

        public double Diameter()
        {
            return 2 * Radius;
        }

        public double SurfaceArea()
        {
            return 4 * (Math.PI * Math.Pow(Radius, 2));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("{0} Radius: {1}\n{0} Volume: {2}\n{0} Diameter: {3}\n{0} Surface Area: {4}", Name, Radius, Volume(), Diameter(), SurfaceArea());
        }
    }
}
