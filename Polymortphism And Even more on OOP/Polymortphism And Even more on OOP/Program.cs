using Polymortphism_And_Even_more_on_OOP.Abstract;
using Polymortphism_And_Even_more_on_OOP.Sealed_Keyword;
using System;
using System.Collections.Generic;
using System.IO;

namespace Polymortphism_And_Even_more_on_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // ============= Polymorphism ===============
            // ==========================================

            // Create a base Class Car with two properties HP and Color
            // Create a constructor setting those two properties.
            // Create a method called ShowDetails() which displays the HP and Color of the car.
            // Create a repair Method which writes "Car was repaired" onto the console.
            // Create two deriving classes BMW and Auti, which have their own constructor and additional property
            // called Model. Also a private member called brand. Brand should be different in each two classes.
            // Create two methods showdetails() and repair them as well. Adjust those methods acccordingly.

            // Inherited classes can use overriden base clas methods
            // Polymorphism lets us declare Car types (car child classes) as new Cars (Parent class)
            //var cars = new List<Car>
            //{
            //    new Audi(200, "blue","A4"),
            //    new BMW(120f, "red","M3"),
            //};

            ////foreach (Car car in cars)
            ////{
            ////    car.ShowDetails();
            ////    car.RepairCar();
            ////}

            //Car bmwZ3 = new BMW(200, "Black", "Z3");
            //Car AudiA3 = new Audi(100, "Blue", "A3");

            //Console.WriteLine("Calling the car ShowDetails()");
            //bmwZ3.ShowDetails(); // This one calls the Car method 
            //Console.WriteLine("\nCalling the Audi ShowDetails()");
            //AudiA3.ShowDetails();
            //Console.WriteLine();

            //Console.WriteLine("Calling the BMW new ShowDetails()");
            //BMW bmwZ4 = new BMW(200, "Black", "Z4");
            //bmwZ4.ShowDetails();
            //// If you want to hide base class members with new members, you can use the "new" keyword.

            ///// Calling base class Car method show details.
            //Car carB = (Car)bmwZ4;
            //carB.ShowDetails();
            // ==========================================
            // ============ Sealed KeyWord ==============
            // ==========================================

            // The sealed keyword prevents deriving classes to override methods.

            // Created new M3 class
            //M3 myM3 = new M3(150, "Blue", "M3");
            //myM3.RepairCar();


            // ==========================================
            // ========== Has A - Relationship ==========
            // ==========================================

            // Composition.
            // Created new class CarIDInfo.
            // The car class HAS A CarIDInfo. Every Car object has a CarIDInfo object.

            //Car bmwZ3 = new BMW(200, "Black", "Z3");
            //Car AudiA3 = new Audi(100, "Blue", "A3");

            //Console.WriteLine("Calling base class Car ShowDetails()");
            //bmwZ3.ShowDetails(); // This one calls the Car method 
            //Console.WriteLine("\nCalling the Audi ShowDetails()");
            //AudiA3.ShowDetails();
            //Console.WriteLine();
            //Console.WriteLine("Setting car info for BMW and Audi");
            //bmwZ3.SetCarIDInfo(1, "Jimmy");
            //AudiA3.SetCarIDInfo(2, "Tim");

            //bmwZ3.GetCarIDInfo();
            //AudiA3.GetCarIDInfo();

            // ==========================================
            // =============== Abstract =================
            // ==========================================

            // Creating Abstract Class Shape.
            // You can't create abstract class objects but you can use it's methods and properties.

            //Cube myCube = new Cube(5);

            //myCube.GetInfo();
            //Console.WriteLine("Volume: {0}", myCube.Volume());
            //Console.WriteLine();
            //// Challenge, create another shape Sphere
            //Sphere mySphere = new Sphere(3);
            //mySphere.GetInfo();
            //Console.WriteLine();

            //Shape[] shapes = { new Sphere(5), new Cube(2) };
            //foreach (Shape shape in shapes)
            //{
            //    shape.GetInfo();
            //    Console.WriteLine();
            //}

            // ===============================================
            // = Abstract and as & is Keyword / Polymorphism =
            // ===============================================

            //Shape[] shapes = { new Sphere(5), new Cube(2) };
            //foreach (Shape shape in shapes)
            //{
            //    shape.GetInfo();
            //    Console.WriteLine();

            //    // Using as keyword to create a variable as a certain type.
            //    // In this instance, Cube.
            //    Cube iceCube = shape as Cube;
            //    if (iceCube == null)
            //    {
            //        Console.WriteLine("Shape above is not a cube");
            //    } 

            //    // Using is keyword. (Checking if shape is a Cube)
            //    // Is keyword used to check if a variable is of a certain type.
            //    if(shape is Cube)
            //    {
            //        Console.WriteLine("This shape above is a cube");
            //    }

            //    object cube1 = new Cube(7);
            //    Cube cube2 = (Cube)cube1; // This parse will only work if cube1 object is a cube

            //    cube2.GetInfo();
            //}


            // ==========================================
            // ===== Interfaces vs Abstract Classes =====
            // ==========================================

            // Important to know about these concept so that we can build 
            // loosely coupled programs. That means programs that we can modify
            // without breaking everything.

            // ABSTRACT CLASSES

            // "What the object is"

            // A class (incomplete class) designed to be inherited by Subclasses.
            // Why would we need abstract classes.
            // Imagine base class vehicle and child classes motorcycle & Car
            // If motorcycle and car class share functionality, a vehicle abstract class is 
            // created as a base class that forces the implementation of these common methods.
            // We can take advantage of abstract classes to design components and specify some 
            // level of common functionality that can be implemented by derived classes.

            // INTERFACES

            // "What the object can do"

            // An interface is a contract 
            // It can only contain method declarations. It cannot contain method definitions.
            // Imagine we have 3 classes, bicycle, motorcycle and car. Then we want to make sure 
            // these classes inherit from this class vehicle. If you want to add self-driving functionality
            // for our car and we want to create other classes like airplane, it doesn't make sense to add the
            // self-driving car feature to the base class. It would be more convenient to add it in the form of
            // an interface called ISelfDriving.

            // SIMILARITIES between Abstract Classes and Interfaces

            // - Cannot be instantiated
            // - They both support Polymorphism. 
            //   Example: (We can store an object of type cat in a variable of abstract class animal)
            // The same thing goes for interfaces where we can store a Generic Collection in type Enumerable

            // KEY DIFFERENCES between Abstract Classes and Interfaces

            // INTERFACE

            // - Not implemented at all
            // - Can't have Constructor
            // - Contains only method declarations
            // - No fields
            // - Classes can implement more than one interface (Multi Inheritance)
            // - Classes must imlement all it's members

            // ABSTRACT CLASS

            // - Either partially implemented or not implemented at all.
            //          Implementation is the responsibility of the class that implemented the interface 
            // - Can have constructors
            // - May contain method definitions and fields.
            // - Classes can extend (Inherit) one class only.
            // - Classes must implement abstract members only.

            // ANALOGY

            // Instructor at Tutorials.EU
            // Instructor: Abstract class.
            // C# Instructor: Concrete Class.
            // IVideo Editor: interface

            // Not all instructors need to edit, but those that extend the
            // IVideo Editor MUST know how to edit.


            // When to choose Inheritance over Interfaces when designing C# Class Libraries.

            // Use an abstract class if you have some functionality that you want subclasses to have.
            // If you have a set of functions you want subclasses to have, put them in an abstract class.
            // Use an abstract class and define each method once. 

            // Use an interface if you want a general contract or behavior or functionality.
            // You don't want to use interfaces in situations where you're constantly 
            // writing the same code.

            // ==========================================
            // ========= Read from a Text File ==========
            // ==========================================

            // to read from a file, create a string where you want to save what you read.
            //string text = System.IO.File.ReadAllText(@"Path Hidden");

            //Console.WriteLine("Text Read: \n{0}", text);

            // storing text file line by line in array. Each array item represents a read text line.
            //string[] lines = System.IO.File.ReadAllLines(@"Path Hidden");

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    Console.WriteLine("Text in line {0}: {1}", i+1 , lines[i]);
            //}

            // ==========================================
            // ========= Write Into a Text File =========
            // ==========================================

            // METHOD 1
            // Write to file by line.
            string[] lines = { "First Line", "Second Line", "Third Line", "Two birds", "Three Ducks", "Two Lines"};

            // Creating new TextFile2.
            // WriteAllLines(string path, string[] lines)
            //File.WriteAllLines(@"C:\Users\jonac\Desktop\myCareer\Udemy Lessons\Complete C# Masterclass\Polymortphism And Even more on OOP\Polymortphism And Even more on OOP\TextFile\TextFile2.txt", lines);

            // Challenge: Write the high scores of 3 users into an array
            string[] highScores = {"5","155","123" };
            //File.WriteAllLines(@"C:\Users\jonac\Desktop\myCareer\Udemy Lessons\Complete C# Masterclass\Polymortphism And Even more on OOP\Polymortphism And Even more on OOP\TextFile\highscores.txt", highScores);


            // METHOD 2
            // Write to file with a string.
            //Console.Write("Enter a file Name: ");
            //string fileName = Console.ReadLine();
            //fileName += ".txt";
            //Console.Write("Enter some text for the file {0}: ", fileName);
            //string input = Console.ReadLine();

            //File.WriteAllText(@"C:\Users\jonac\Desktop\myCareer\Udemy Lessons\Complete C# Masterclass\Polymortphism And Even more on OOP\Polymortphism And Even more on OOP\TextFile\"+fileName, input);

            // METHOD 3 (Streamline)
            //using (StreamWriter file = new StreamWriter(@"C:\Users\jonac\Desktop\myCareer\Udemy Lessons\Complete C# Masterclass\Polymortphism And Even more on OOP\Polymortphism And Even more on OOP\TextFile\myStreamWriterText2.txt"))
            //{
            //    //foreach (string line in lines)
            //    //{
            //    //    // I only want to write into the file if there was the word "Third" in the line
            //    //    if (line.Contains("Third"))
            //    //    {
            //    //        file.WriteLine(line);
            //    //    }
            //    //}
                
            //    // Challenge: Create another text file that writes when lines list contains "Two" 
            //    foreach (string line in lines)
            //    {
            //        // I only want to write into the file if there was the word "Third" in the line
            //        if (line.Contains("Two"))
            //        {
            //            file.WriteLine(line);
            //        }
            //    }
            //}

            // Writing on a file and appending text (Write more text instead of overwriting text file)
            using (StreamWriter file = new StreamWriter(@"TextFile\myStreamWriterText2.txt", true))
            {

                // Challenge: Create another text file that writes when lines list contains "Two" 
                foreach (string line in lines)
                {
                    // I only want to write into the file if there was the word "Third" in the line
                    if (line.Contains("Two"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}
