using Events_And_Delegates.Creating_Your_Own_Delegates;
using Events_And_Delegates.Events_and_Multicast_Delegates;
using System;
using System.Collections.Generic;

namespace Events_And_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==============================================
            // ============ Events and Delegates ============
            // ==============================================

            // A delegate is a type that can hold a reference to a method.
            // Imagine a button with certain properties.
            // text, backColor, sizeWidth, sizeHeight.
            // What about the code that executes when the button is pressed??
            // That's where event delegates come in.

            // delegates hold that method to be executed.
            // Delegate example: private delegate void OnClickDelegate();

            // Method OnClickDelegate() is used by the delegate;

            // Example method SendButtonClick: 
            // void SendButtonClick() {
            //    Network.Connect();
            //    Network.Connect();
            //    DisplayMessageSentDialog();
            // }

            // SendButton.OnClick = SendButtonClick;

            // if(IsMouseHovering && IsLeftClickPressed) {
            //     SendButton.OnClick();
            // }

            // ==============================================
            // ============== Delegates Basics ==============
            // ==============================================

            // Using delegate that already exists in C#.
            //List<string> names = new List<string>() { "Jake", "Sora", "Link", "Noctis", "Seth" };
            //// RemovesAll Method takes in a Predicate<string> match which is a Delegate.
            //// Predicate is a delegate which takes an object of type T. (Type of our list elements). It returns a boolean.
            //// Rempves all elements that match the conditions defined.
            //// When we call removeAll, a predicate will be executed in all names on the list, Predicate is a Delegate.

            //Console.WriteLine("---- Before ----");
            //// Prints names before the remove all method
            //foreach (string name in names)
            //{
            //    Console.Write(name+ ", ");
            //}
            //names.RemoveAll(Filter);

            //Console.WriteLine("\n\n---- After ----");
            //// Prints names before the remove all method
            //foreach (string name in names)
            //{
            //    Console.Write(name + ", ");
            //}

            // ==============================================
            // ========= Creating your Own Delegates ========
            // ==============================================

            // Creating Person Class.
            // Creating a list of people.
            //List<Person> people = new List<Person>()
            //{
            //    new Person("Tim", 20),
            //    new Person("Luis", 46),
            //    new Person("Crab", 68),
            //    new Person("Sora", 16),
            //    new Person("Mike", 20),
            //    new Person("Tom", 20),
            //    new Person("Link", 17),
            //    new Person("Linda", 15),
            //};


            //DisplayPeople("Kids", people, IsMinor);
            //DisplayPeople("Adults", people, IsAdult);

            // ==============================================
            // ============== Anonymous Methods =============
            // ==============================================

            // Anonymous methods are Methods without a name. 
            // This relieves us of having to create many dedicated methods for our delegates.

            //List<Person> people = new List<Person>()
            //{
            //    new Person("Tim", 20),
            //    new Person("Luis", 46),
            //    new Person("Crab", 68),
            //    new Person("Sora", 16),
            //    new Person("Mike", 23),
            //    new Person("Tom", 26),
            //    new Person("Link", 17),
            //    new Person("Linda", 15),
            //};


            //DisplayPeople("Kids", people, IsMinor);
            //DisplayPeople("Adults", people, IsAdult);

            //// Here we created a variable of type FilterDelegate.
            //// Then we assigned an anonymous method to it instead of an already defined method.
            //FilterDelegate filter = delegate (Person p)
            //{
            //    return p.Age >= 20 && p.Age <= 30;
            //};
            //Console.WriteLine();
            //DisplayPeople("Middle Aged", people, filter);

            //Console.WriteLine();
            //// We can also pass anonymous methods directly as parameters
            //DisplayPeople("All People", people, delegate (Person p) { return true; });

            // ==============================================
            // ============== Lambda Expression =============
            // ==============================================

            // Lambda comes from lambda calculus where everything is expressed in terms of functions.
            // They provide a simple and more compact method of writing anonymous functions.

            // Lambda declaration operator: =>
            // Example: (parameters) => {
            //      Code Here
            // }

            //List<Person> people = new List<Person>()
            //{
            //    new Person("Tim", 20),
            //    new Person("Luis", 46),
            //    new Person("Crab", 68),
            //    new Person("Sora", 16),
            //    new Person("Mike", 23),
            //    new Person("Tom", 26),
            //    new Person("Link", 17),
            //    new Person("Linda", 15),
            //    new Person("Aurelius", 22),
            //    new Person("Snape", 45),
            //    new Person("Tonks", 29),
            //    new Person("Harry", 25),
            //    new Person("Grinderwald", 25),
            //};


            //DisplayPeople("Kids", people, IsMinor);
            //DisplayPeople("Adults", people, IsAdult);

            //// Here we created a variable of type FilterDelegate.
            //// Then we assigned an anonymous method to it instead of an already defined method.
            //FilterDelegate filter = delegate (Person p)
            //{
            //    return p.Age >= 20 && p.Age <= 30;
            //};
            //Console.WriteLine();
            //DisplayPeople("Middle Aged", people, filter);

            //Console.WriteLine();
            //// We can also pass anonymous methods directly as parameters
            //DisplayPeople("All People", people, delegate (Person p) { return true; });

            //// Creating filters using Lambda expressions
            //Console.WriteLine();
            //string SearchKey = "a";
            //// Using statement Lambda
            //DisplayPeople($"age > 20 and have letter {SearchKey}", people,p => {
            //    return p.Age > 20 && p.Name.ToLower().Contains(SearchKey); 
            //});
            //Console.WriteLine();
            //// Expression lambda
            //DisplayPeople($"People with age = 25", people, p => p.Age == 25);

            // ==============================================
            // ======= Events and Multicast Delegates =======
            // ==============================================

            // Multicast Delegates are delegates in which we store more than one method. (Like a list of methods)

            // Creating classses AudioSystem, RenderingEngine and Player
            // Creating objects
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();
            Player player1 = new Player("SilverSurfer");
            Player player2 = new Player("DougLess");

            // Start Audio System and Rendering Engine.
            // ---------------- Methods are now private --------------------
            //audioSystem.StartGame();
            //renderingEngine.StartGame();
            //Console.WriteLine();
            //// Spawn the Players
            //player1.StartGame();
            //player2.StartGame();

            //Console.WriteLine("Game started. Press any key to end game.");
            //Console.ReadKey();
            //Console.WriteLine();
            //player1.GameOver();
            //player2.GameOver();

            //audioSystem.GameOver();
            //renderingEngine.GameOver();
            // ---------------- Methods are now private --------------------
            // Since all method are now private, we cannot use them anymore. commenting code above.

            // Using Multicast delegate from the GameEventManager class.
            GameEventManager.TriggerGameStart();
            Console.WriteLine("Game started. Press any key to end game.");
            Console.ReadKey();
            Console.WriteLine();
            GameEventManager.TriggerGameOver();

            Console.WriteLine();
            Console.WriteLine("Creating new player 3.");
            Player player3 = new Player("KingCrop");

            GameEventManager.TriggerGameStart();
            Console.WriteLine("Game started. Press any key to end game.");
            Console.ReadKey();
            Console.WriteLine();
            GameEventManager.TriggerGameOver();

            // You could by mistake use the = sign instead of the += sign in the constructor of
            // Objects that have delegates. This could result in us reasigning our multicast delegates instead
            // of adding the methods to the multicast delegate.

            // To avoid this error, use the event keyword.
            // Events are forced to behave like a list, meaning we can only add or remove to it.
            // += / -= is valid
            // = is not valid

            // Delegates allows a direct assignment
            // myDelegate = myMethod

            // Events can't be triggered from outside the class that defines them.
        }

        // defining a delegate type called FilterDelegate that takes a person object and returns a bool
        public delegate bool FilterDelegate(Person p);

        // Method will take a list of people and filter Person by age as a delegate.
        // Method will display the people that pass the filter.
        // Method takes a title to be displayed, a list of people and a filter delegate.
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            // Write title
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                // check if this person passes the filter
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old",  p.Name, p.Age);
                }
            }
        }

        // =========== Filters ===========
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        // This will be used as a delegate
        static bool Filter(string s)
        {
            // Return whether the string s contains the letter 'i'
            return s.Contains("i");
        }
    }
}
