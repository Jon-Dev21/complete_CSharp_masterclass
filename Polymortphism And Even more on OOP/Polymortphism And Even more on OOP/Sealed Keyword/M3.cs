using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymortphism_And_Even_more_on_OOP.Sealed_Keyword
{
    class M3:BMW 
    {

        public M3(float hp, string color, string model) : base(hp, color, model)
        {
            Model = model;
        }

     
        // Cannot override this method since the BMW class method repair car containes sealed keyword
        //public override void RepairCar()
        //{
        //    base.RepairCar();
        //}
    }
}
