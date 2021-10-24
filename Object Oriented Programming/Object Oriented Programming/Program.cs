using System;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==================================================
            // ========= Object Oriented Programming ============
            // ==================================================

            // Class: A Class is a blueprint of an object
            // Classes have actions / abilities known as member functions or methods.
            // Classes also have properties or member variables.
            // Classes habilitate inheritance.
            // Classes can be used as a data type.

            // Object: Instance of a class.

            // ==================================================
            // ============= Creating a Class ===================
            // ==================================================

            // to run the example code below, make the firstName and lastName properties public.

            // Creating an object of the class Human
            //Human John = new Human();
            //// Can access and change public variables from outside a class.
            //John.firstName = "John";
            //John.lastName = "Hopkins";

            //// Can call public methods of the class
            //John.IntroduceMyself();

            //Human Michael = new Human();
            //Michael.firstName = "Mike";
            //Michael.lastName = "Jackson";

            //Michael.IntroduceMyself();

            // ==================================================
            // ============= Using Constructors =================
            // ==================================================

            //Human Tim = new Human("Tim", "Burton", "Brown", 30);
            //Tim.HowOldAmI();
            //Tim.AboutMyself();

            // ==================================================
            // ========= Using Multiple Constructors ============
            // ==================================================

            // Using default constructor
            //Human defaultCons = new Human();

            // using parametized constructor with 1 parameter
            //Human human0 = new Human("Tim");
            //human0.IntroduceMyself();

            // using parametized constructor with 2 parameters
            //Human human1 = new Human("Tim", "Burton");
            //human1.IntroduceMyself();

            // using parametized constructor with 3 parameters
            //Human human2 = new Human("John", "Connor", "Brown");
            //human2.IntroduceMyself();

            // using parametized constructor with 4 parameters
            //Human human3 = new Human("Jimmy", "Neutron", "Blue", 20);
            //human3.IntroduceMyself();

            // ==================================================
            // =============== Access Modifiers =================
            // ==================================================

            /* Read about them here
               https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers 
               https://code-maze.com/csharp-basics-access-modifiers/
             */


            // ==================================================
            // ================== Properties ====================
            // ==================================================

            // creating new class Box

            Box box = new Box(3,4,5);

            // Having public properties makes for unsafe code.
            //box.length = 3;
            //box.height = 4;
            //box.width = 5;

            // It's a safer practice to use setters and getter methods inside the class

            // Using setter methods
            //box.SetLength(3);
            //box.SetHeight(4);
            //box.SetWidth(5);
            // Using property width to set the width
            //box.Width = 5;

            //Console.WriteLine("Box Width: {0} ",box.Width);
            //box.Width = 7;
            //Console.WriteLine("Box Volume: {0} ", box.Volume);
            //Console.WriteLine();
            //Console.WriteLine("Displaying box info: ");
            //box.DisplayInfo();
            //Console.WriteLine();
            //Console.WriteLine("Setting height property with new Height Property with getting and setting capabilities: ");
            //box.Height = -6;

            //Console.WriteLine("Getting Height with classic getter method: {0}", box.GetHeight());
            //Console.WriteLine("Getting Height with new Height getter/setter property: {0}", box.Height);


            // ==================================================
            // ============ Challenge - Properties ==============
            // ==================================================

            //box.DisplayInfo();

            //// Create a read only property "Front Surface" which calculates the front surface based on height and length.
            //Console.WriteLine("Front Surface: {0} x {1} = {2}",box.Height, box.GetLength() ,box.FrontSurface);


            // ==================================================
            // ====== Members and Finalizers/Destructors ========
            // ==================================================

            // Creating new Members Class
            Members member = new Members();
            Console.WriteLine();
            member.Introducing(false);
            
        }
    }
}
