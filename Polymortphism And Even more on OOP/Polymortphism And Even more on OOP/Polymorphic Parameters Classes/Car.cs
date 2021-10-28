using Polymortphism_And_Even_more_on_OOP.Has_A___Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymortphism_And_Even_more_on_OOP
{
    class Car
    {
        // If you want to hide base class members with new members, you can use the "new" keyword.
        public float HorsePower { get; set; }
        public string Color { get; set; }

        // Has A - Relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("Car ID: {0}\nOwner: {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car()
        {
            HorsePower = 120f;
            Color = "Black";
        }

        // simple constructor
        public Car(float hp, string color)
        {
            HorsePower = hp;
            Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Horse Power: {0}\nColor: {1}",HorsePower,Color);
        }

        public virtual void RepairCar()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
