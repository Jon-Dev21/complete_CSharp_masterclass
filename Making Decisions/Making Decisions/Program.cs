using System;

namespace Making_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // =================================================
            // ==== Decision Making with If/Else Statements ====
            // =================================================
            //bool isCSharpCool = true;
            //if (isCSharpCool)
            //{
            //    Console.WriteLine("C# is the coolest.");
            //} else
            //{
            //    Console.WriteLine("Even if the variable is false, C# is still the coolest.");
            //}

            //Console.Write("Enter the temperature in degrees celcius: ");
            //string temperature = Console.ReadLine();
            //int numTemp = int.Parse(temperature);

            //if (numTemp < 20)
            //{
            //    Console.WriteLine("Take the coat.");
            //} else if(numTemp == 20)
            //{
            //    Console.WriteLine("It's 20 degrees C°. Pants should be fine.");
            //} else
            //{
            //    Console.WriteLine("It's cozy and warm! Shorts are enough today.");
            //}

            // ==========================================================================================

            // =================================================
            // ========== Introduction to TryParse() ===========
            // =================================================

            // Used to convert a string into numeric data types.
            // TryParse is mostly used to avoid program crashes while parsing.
            // Example: 
            //string numAsString = "128d";

            //bool isParsed = int.TryParse(numAsString, out int parsedValue);

            //if (isParsed)
            //{
            //    Console.WriteLine("Value {0} parsed successfully", numAsString);
            //} else
            //{
            //    Console.WriteLine("Value {0} could not be parsed to int", numAsString);
            //}

            //// Attempting with float
            //string floatAsString = "128.423";

            //bool isFloatParsed = float.TryParse(floatAsString, out float parsedFloatNum);

            //if (isFloatParsed)
            //{
            //    Console.WriteLine("Value {0} parsed successfully", parsedFloatNum);
            //}
            //else
            //{
            //    Console.WriteLine("Value {0} could not be parsed to float", floatAsString);
            //}
            //Console.WriteLine();
            //Console.WriteLine("TryParse with user input");
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            //// Using tryParse in condition
            //if (int.TryParse(input, out int parsedVal))
            //{
            //    Console.WriteLine("Input {0} parsed successfully", parsedVal);
            //}
            //else
            //{
            //    Console.WriteLine("Input {0} could not be parsed to int", input);
            //}

            // ==========================================================================================

            // =================================================
            // ============= Nested If Statements ==============
            // =================================================

            //bool isAdmin = false;
            //bool isRegistered = true;
            //Console.Write("Please enter your username: ");
            //string userName = Console.ReadLine();

            //if(isRegistered && userName != "" && userName.ToLower().Equals("admin"))
            //{
            //    Console.WriteLine("Hello, Admin.");
            //} else if(isRegistered && userName !="" && !userName.ToLower().Equals("admin"))
            //{
            //    Console.WriteLine("Hi there, {0}", userName);
            //} else if (isRegistered)
            //{
            //    Console.WriteLine("Hi there, Registered user");
            //} else
            //{
            //    Console.WriteLine("Please make an account. ");
            //}

            //if(isAdmin || isRegistered)
            //{
            //    Console.WriteLine("You are logged in.");
            //}

            // ==========================================================================================

            // =================================================
            // =========== Challenge - If Statements ===========
            // =================================================

            /*
             Create a user Login System, where the user can first register and then Log in. 
            The Program should check if the user has entered the correct username and password, 
            when logging in (so the same ones that he used when registering).
            As we haven't covered storing data yet, just create the program in a way, 
            that registering and logging in, happen in the same execution of it.
            User If statements and User Input and Methods to solve the challenge.
            */
            // Will register here.
            Console.WriteLine("Register to create an account.");
            Console.WriteLine();
            Console.Write("Enter a new username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter a new password: ");
            string passWord = Console.ReadLine();
            if(userName != "" && passWord != "")
            {
                Console.WriteLine("Registered successfully. Your username is {0}.", userName);
                LogIn(userName, passWord);
            } else if(userName == "" && passWord != "")
            {
                Console.WriteLine("Username is empty. Must enter a username to register.");
            }
            else if (userName != "" && passWord == "")
            {
                Console.WriteLine("Password is empty. Must enter a password to register.");
            }
            else
            {
                Console.WriteLine("Please provide a username and password to register.");
            }




            // ==========================================================================================
            // ==========================================================================================
            // ==========================================================================================
        }
        public static void LogIn(string registeredName, string registeredPw)
        {
            Console.WriteLine();
            Console.WriteLine("Logging In");
            Console.WriteLine();
            Console.Write("Enter your username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your password: ");
            string passWord = Console.ReadLine();
            if (userName.Equals(registeredName) && passWord.Equals(registeredPw))
            {
                Console.WriteLine("Logged In. Welcome, {0}", userName);
            } else
            {
                Console.WriteLine("Incorrect username or password.");
            }           
        }
    }
}
