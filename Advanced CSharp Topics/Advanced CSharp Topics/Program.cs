using System;

namespace Advanced_CSharp_Topics
{
    // Creating struct Game
    public struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine("Game 1's Name: {0}", name);
            Console.WriteLine("Game 1 developed by: {0}", developer);
            Console.WriteLine("Game 1's Rating: {0}", rating);
            Console.WriteLine("Game 1's Release Date: {0}", releaseDate);
        }
    }

    // Creating enum Day
    enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December };

    class Program
    {
        static void Main(string[] args)
        {
            // ===============================================
            // ========= .Net Core vs .Net Framework =========
            // ===============================================

            // Article: https://stackify.com/net-core-vs-net-framework/


            // ===============================================
            // =============== Access Modifiers ==============
            // ===============================================

            // Allow you to grant and prevent access.
            // Marking fields and methods with access modifiers is part of OOP and increases
            // the safeness of your code. They are an important part of encapsulation.

            // In OOP, encapsulation is used to refer to one of two related but distinct notions,
            // And sometimes to the combination thereof:

            //   - A language mechanism for restricting direct access to some of the Object's components.
            //   - A language construct that facilitates the bundling of data with the methods
            //     or other fucntions operating on that data.

            // ACCESS MODIFIER: PRIVATE
            // private = Only accessible inside a class or struct
            // private int age = 18;
            // private void Walk()
            //{ }


            // ACCESS MODIFIER: PUBLIC
            // public = Accessible everywhere in your proyect
            // public int age = 18;
            // public void Walk()
            //{ }

            // ACCESS MODIFIER: PROTECTED
            // protected = Accessible from the class and all classes that derive from it.
            // protected int age = 18;
            // protected void Walk()
            //{ }

            // ACCESS MODIFIER: PROTECTED
            // internal = Accessible from it's assembly or namespace (project).
            // internal int age = 18;
            // internal void Walk()
            //{ }


            // HOW TO USE ACCESS MODIFIERS CORRECTLY?

            // As a rule of thumb, whenever you declare a new class, member or method, it is recommended
            // initially going with the most restrictive access modifier that will allow your program to work
            // (and then easing that as and when necessary).

            // WHY SHOULD YOU USE ACCESS MODIFIERS?

            // They give you full control over your methods and variables.
            // You control who can modify or use your methods and variables.
            // Careless use of access modifiers could result in breaking of your program.



            // ===============================================
            // ================== Structs ====================
            // ===============================================

            // Structs are very similar to classes.
            // Classes are reference types and structs are value types
            // meaning classes can contain nothing but structs NEED to have a value.


            // Creating struct called Game in line 6 of this program.

            // Declaring struct 
            //Game game1;

            //game1.name = "Pokemon GO";
            //game1.developer = "Niantic";
            //game1.rating = 3.5;
            //game1.Display();   Can't use the display method before assigning all values since structs are value types.
            //game1.releaseDate = "1/7/2016";


            //game1.Display();
            //Game game2 = new Game("Pokemon GO 2", "Niantic", 4, "1/7/2020");

            //game2.Display();
            // DIFFERENCE BETWEEN CLASS AND STRUCT

            // - You cannot create a default constructor with a struct.
            // - Does not support inheritance.
            // - Struct methods can't be abstract, virtual or protected. Only public or private.


            // ===============================================
            // ================== Enums ======================
            // ===============================================

            // Enums are sets of inmutable constants.
            // Enums should be placed at namespace level.

            // Creating enum Day at line 31
            // Creating enum day Monday
            //Day monday = Day.Monday;
            //Day sunday = Day.Sunday;
            //Day friday = Day.Friday;

            //Console.WriteLine("Check if monday is equal to friday");
            //Console.WriteLine(monday == friday);

            //Console.WriteLine("Getting Day.Monday");
            //Console.WriteLine(Day.Monday);
            //Console.WriteLine("Parsing Day.Monday to int. (Getting index)");
            //Console.WriteLine(((int)Day.Monday));

            //// Challenge. Create an enum with the months of the year
            //Console.WriteLine("Getting Months.February");
            //Console.WriteLine(Months.February);
            //Console.WriteLine("Parsing Months.February to int. (Getting index)");
            //Console.WriteLine(((int)Months.February));

            //Console.WriteLine("Comparing string January to Month.January.ToString()");
            //Console.WriteLine("January" == Months.January.ToString());
            // enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December };
            // January = 1 makes the enum indexes start at 1.
            // You can configure custom indexes to the enums.

            // ===============================================
            // ================== Math Class =================
            // ===============================================

            // To use math class, include "using System.Math" 

            // Rounding numbers up or down.
            //double num = 10.5;
            //Console.WriteLine("Round Up (Ceiling) Value {0}: {1}", num, Math.Ceiling(num));
            //Console.WriteLine("Round Down (Floow) Value {0}: {1}", num, Math.Floor(num));

            //// Getting Min and Max values.
            //int num1 = 13;
            //int num2 = 15;
            //Console.WriteLine("\nGetting lower of the two values {0} and {1}: {2}", num1, num2, Math.Min(num1, num2));
            //Console.WriteLine("\nGetting greater of the two values {0} and {1}: {2}", num1, num2, Math.Max(num1, num2));

            //// To the power of. (Math.Pow(number, power))
            //Console.WriteLine("3 to the power of 5: {0}", Math.Pow(3,5));

            //// PI
            //Console.WriteLine("\nMath.PI: {0}", Math.PI);

            //// Square root.
            //Console.WriteLine("\nSquare root of 25 is {0}", Math.Sqrt(25));

            //// Absolute numbers. (Always positive)
            //Console.WriteLine("\nAbsolute value of -100", Math.Abs(-100));

            //// Cosine
            //Console.WriteLine("\nCos of 1 is: {0}", Math.Cos(1));

            // ===============================================
            // ================= Random Class ================
            // ===============================================

            //Random dice = new Random();
            //int numEyes; // Number of eyes in our dice.

            //// Roll dice 10 times
            //for (int i = 0; i < 10; i++)
            //{
            //    // Random number between 1 and 6. 7 Not included
            //    numEyes = dice.Next(1,7);
            //    Console.WriteLine("Dice landed on {0}", numEyes);
            //}

            //Random yesNoMaybe = new Random();
            //int answerNum = yesNoMaybe.Next(1,4);

            //Console.WriteLine("\nDo you love C#?");

            //Console.WriteLine("Answer Num: {0}", answerNum);
            //if(answerNum == 1)
            //{
            //    Console.WriteLine("Yes");
            //} else if (answerNum == 2){
            //    Console.WriteLine("Maybe");
            //} else
            //{
            //    Console.WriteLine("No");
            //}


            // ===============================================
            // ============= Regular Expressions =============
            // ===============================================

            /*
             VS 2019 and Regular expressions
                Hi everyone. As it seems, there is a bug in VS 2019 when it comes to Regular Expressions. 
                "in Visual Studio 2019, you must have Match Case enabled in order for the Capitalized Regex 
                modifiers to work properly." If you find the behaviour of VS to be different than in the Video,
                please check out this post by Derek in the Q&A section of the Regular Expression Video.
             */
        }
    }
}
