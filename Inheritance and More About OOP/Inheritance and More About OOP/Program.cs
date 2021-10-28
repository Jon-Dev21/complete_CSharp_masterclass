using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;

namespace Inheritance_and_More_About_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============================================
            // ============ Inheritance in C# =============
            // ============================================

            // Inheritance allows us to define a class in terms of another class,
            // which makes it easier to create and maintain an application.
            // This also provides an opportunity to reuse the code functionality
            // and speeds up implementation time. (A Class inherits
            // and can use methods and properties from another class).

            // Example For inheritance

            // Base Class: Car
            // Properties: Horse power, Windows, Wheels.
            // Methods: Drive, Honk

            // Deriving Classes: 
            // Race Car. Property: Turbo. Method: Racing
            // Streets Car. Property: Comfort. Method: Streetride

            // ============================================
            // ======== Simple Inheritance Example ========
            // ============================================

            // Inheritence allows you to define a child class that inherits or 
            // Modifies the parent's class behavior.

            // Child or derived class uses Parent or base class methods and properties.

            // Creating New Class Radio
            // Creating New Class TV
            // Creating New Base class Electrical Device

            // Our TV and Radio class will inherit (extend) the functionalities from the Electrical Device class.

            //Radio myRadio = new Radio(false, "Sony");
            //TV myTV = new TV(false, "Samsung");
            //Console.WriteLine("Using Radio\n");
            //myRadio.ListenRadio();
            //myRadio.SwitchOn();
            //myRadio.ListenRadio();
            //Console.WriteLine("Now using TV\n");
            //myTV.WatchTV();
            //myTV.SwitchOn();
            //myTV.WatchTV();


            // ============================================
            // ======= Virtual and Override Keywords ======
            // ============================================

            // Creating Animal Class
            // The virtual keyword is used to enable child classes to rewrite base class methods.
            // Creating Dog class.
            // The override keyword is used to enable method overriding in child / derived classes.
            // (an example is overriding the MakeSound() and Play() method for the Dog Class.

            // Declaring our dog
            //Dog dog = new Dog("Mocco", 63, false);
            //Console.WriteLine("{0} is {1} years old", dog.Name, dog.Age);
            //dog.MakeSound();
            //dog.Eat();
            //dog.Play();
            //dog.IsHungry = true;
            //dog.Eat();

            // ============================================
            // ============= Inheritance Demo =============
            // ============================================

            // Creating Class Post. This class represents a web post
            // protected keyword means that the defined property, variable, method, etc. 
            // can only be used by the defining class and by each inheriting class.
            //Post post1 = new Post("This is my first post here", true, "calculus21");
            //Post post2 = new Post("This is my second post here", true, "calculus21");
            //Console.WriteLine(post1.ToString());
            //Console.WriteLine(post2.ToString());

            //// Creating ImagePost.
            //ImagePost imagePost1 = new ImagePost("My new Shoes", "calculus21", @"https://www.louisvuitton.com/images/AK3U1ASL33_PM2_Front%20view", true);
            //Console.WriteLine(imagePost1.ToString());

            // ============================================
            // ========== Inheritance Challenge ===========
            // ============================================

            // Add a deriving class "VideoPost wih a property VideoURL, Length.

            // Create the required constructors to create a VideoPost.
            // Adjust the ToString() Method accordingly.
            // Create an instance of video post.

            // More advanced - Use Timer and a callback method here.
            // Create fields as required
            // Add member methods "Play" which should write the current duration of the video.
            // Add "Stop which should stop the timer and write "Stopped at {0}s" onto the console.
            // Play the video after creating the instance and pause it when the user presses any key.

            //VideoPost videoPost1 = new VideoPost("Check out this video", "calculus21", @"https://www.youtube.com/watch?v=dQw4w9WgXcQ", true, 212);
            //Console.WriteLine(videoPost1.ToString());
            //Console.WriteLine("Press enter to start video.");

            //Console.ReadKey();
            //videoPost1.Play();
            //Console.ReadKey();
            //videoPost1.Stop();

            // ============================================
            // ========= Inheritance Challenge 2 ==========
            // ============================================

            /*
            
            These instructions were taken from the Q&A section. The course instructions were very confusing

            Create a Base Class “Employee” with properties FirstName, Surname and Salary. 
            The Employee Class should have two methods called Work() and Pause() which when called 
            will display “I am working” or “I am having a break” respectively.

            Then create a deriving Class “Boss” of Employee with an additional property CompanyCar, 
            containing the name of the boss’s car. Add a method called Lead() which will display the boss’s 
            information when called.

            A second deriving Class “Trainees” of Employee with additional properties, WorkingHours and 
            SchoolHours, containing the number of hours spent weekly working and at school. Add methods Learn() 
            and Work(). Which will display the number of hours doing each when called. Work() called from trainee 
            will override the Work() method created in Employee.

            From the main class, create an instance of each class and call the created methods for each class 
            to show the respective text on the console.

            Do not forget to create the constructors.
             */

            //Employee Stan = new Employee("Stan", "Winston", 10);
            //Boss Rod = new Boss("Rod",  "Bossman", 50, "Lamborghini");
            //Trainee Tim = new Trainee("Tim", "Dillan", 8, 6, 4);

            //Stan.Work();
            //Stan.Pause();

            //Rod.Work();
            //Rod.Pause();
            //Rod.Lead();

            //Tim.Work();
            //Tim.Pause();
            //Tim.Learn();

            // ============================================
            // ================ Interfaces  ===============
            // ============================================

            // Interfaces are like contracts in classes. 
            // Contracts where a class that implements an interface agrees
            // to provide implementations for all objects defined by that interface.
            // This means an interface will contain the contract terms methods and properties
            // But how we implement them is up to the class that implements the interface.

            // Interfaces cannot contain any implementation.
            // Their names are generally prefixed with an I to identify them. Example, IDog.
            // Creating class Ticket that implements interface IEquatable

            //Ticket ticket1 = new Ticket(10);
            //Ticket ticket2 = new Ticket(10);

            //Console.WriteLine("Ticket 1 equal to ticket 2? {0}", ticket1.Equals(ticket2));

            // ============================================
            // == Creating and using your own Interfaces ==
            // ============================================

            // Creating Parent Classes, Vehicle and Furniture.
            // Creating Child Classes, Car and Chair.

            // C# is a single inheritance language.
            // Creating Destruction Feature by creating our own interface (IDestroyable).
            // Created interface IDestroyable

            // Creating two chair objects.
            //Chair officeChair = new Chair("Brown", "Plastic");
            //Chair gamingChair = new Chair("Red", "Wood");

            // Creating new car Object.
            //Car damagedCar = new Car(80f, "Black");

            // Add the two chairs to the IDestroyable list of the car
            // so that when we destroy the car, the destroyable objects
            // that are near the car will get destroyed as well.
            //damagedCar.DestroyablesNearby.Add(officeChair);
            //damagedCar.DestroyablesNearby.Add(gamingChair);

            // Destroy the damaged car!!!
            //damagedCar.Destroy();

            // Interfaces are used for communication between 2 similar or non-similar classes
            // which do not care about the type of class implementing the interface. Just like
            // how the car communicated with the chair just by implementing the same interface.

            // Perks of interfaces:

            // Code readability.
            // Code semantics. (Separating concepts)
            // Code maintainability.
            // Design Patterns (Human understanding and complex system architecture)
            // Multiple inheritance.

            // ============================================
            // ======== IEnumerator and IEnumerable =======
            // ============================================

            // Understand these interfaces to become a more advanced C# Developer.

            // IEnumerable <T> for generic collections.
            // IEnumerable for non-generic collections.

            // IEnumerable Interface is the base interface for many collections in C#.
            // It provides a way to iterate through a collection.

            // Lists and Dictionaries are examples of collections that implement IEnumerable.

            /// <summary>
            /// IEnumerable<T> contains a single method that you must implement when implementing 
            /// this interface. GetEnumerator(), which returns an IEnumerator<T> object.
            /// The returned IEnumerator<T> object provides the ability to iterate through the collection.
            /// by exposing a Current property that points at the object we are currently at in the collection.
            /// </summary>

            /// <summary>
            /// When is it recommended to use the IEnumerable Interface?
            /// - When your collection represents a massive database table,
            ///   you don't want to copy the entire thing into memory and cause performance issues in your application.
            /// When is it NOT recommended to use the IEnumerable Interface?
            /// - When you need results right away and are possibly mutating / editing objects later on.
            ///   In this case, it's better to use an array or a list.
            /// </summary>

            // Creating class Cat. (In course it's a dog class but I already have a dog class. Will create cat class instead)

            //CatShelter myShelter = new CatShelter();

            // Implemented the IEnumerable interface in the CatShelter class in order to iterate through the generic list 
            // collection of cats.
            //foreach (var cat in myShelter)
            //{
            //    cat.GiveTreat(3);
            //}

            // ============================================
            // =========== IEnumerable Example 1 ==========
            // ============================================

            // Created IEnumerable<int> method GetCollections(int option) below this program (Line: )

            // Creating a generic IEnumerable variable that takes any collection of type int.
            // We will use this variable to store the collections that will get returned by the GetCollection() method.
            //IEnumerable<int> unknownCollection;


            //unknownCollection = GetCollection(1);
            //Console.Write("This was a List<int>: ");
            //// foreach number in the collection we got back from GetCollection(1);
            //foreach (int num in unknownCollection)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();
            //unknownCollection = GetCollection(2);
            //Console.Write("This was a Queue<int>: ");
            //// foreach number in the collection we got back from GetCollection(2);
            //foreach (int num in unknownCollection)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();
            //unknownCollection = GetCollection(3);
            //Console.Write("This was an int[]: ");
            //// foreach number in the collection we got back from GetCollection(3);
            //foreach (int num in unknownCollection)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            // ============================================
            // =========== IEnumerable Example 2 ==========
            // ============================================

            // Demo to see how we can pass an IEnumerable<> as a parameter.
            // Created method CollectionSum(IEnumerable<int> anyCollection) below the main method
            List<int> numbersList = new List<int>() { 5, 8, 2, 9, 2 };
            Queue<int> numbersQueue = new Queue<int>();
            // Add values to the queue 
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);
            int[] numbersArray = new int[] { 11, 12, 13, 14, 15 };
            Console.WriteLine(" ");
            CollectionSum(numbersList);
            CollectionSum(numbersQueue);
            CollectionSum(numbersArray);
        }

        /// <summary>
        /// IEnumerable Example 1
        /// This method returns different collections depending on the orders passed.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>(){1,2,3,4,5};
            Queue<int> numbersQueue = new Queue<int>();
            // Add values to the queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);
            
            switch (option)
            {
                // If option is 1 
                case 1:
                    // Return numbersList
                    return numbersList;
                // If option is 2 
                case 2:
                    // Return numbersQueue
                    return numbersQueue;
                default:
                    // Return an array of numbers initialized with some numbers.
                    return new int[] {11,12,13,14,15};
            }
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // Sum variable to store the sum of the numbers in any collection.
            int sum = 0;
            // For each number in the collection passed to this method
            foreach (int num in anyCollection)
            {
                // add the num value to sum
                sum += num;
            }
            Console.WriteLine("Sum of collection is {0}", sum);
        }
    }
}
