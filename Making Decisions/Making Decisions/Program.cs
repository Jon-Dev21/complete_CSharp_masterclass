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
            //Register();
            //LogIn();


            // ==========================================================================================

            // =================================================
            // =============== Switch Statements ===============
            // =================================================

            //int age = 25;

            //switch (age)
            //{
            //    case 15:
            //        Console.WriteLine("Too young for the club.");
            //        break;
            //    case 25:
            //        Console.WriteLine("Good to go.");
            //        break;
            //    default:
            //        Console.WriteLine("How old are you then?");
            //        break;
            //}

            //string username = "Tom";

            //switch (username)
            //{
            //    case "Tim":
            //        Console.WriteLine("Hello, {0}", username);
            //        break;
            //    case "Tom":
            //        Console.WriteLine("Who are you? {0}?", username);
            //        break;
            //    default:
            //        Console.WriteLine("WHO ARE YOU?");
            //        break;
            //}

            // ==========================================================================================

            // =================================================
            // ========== Challenge - If Statements 2 ==========
            // =================================================

            /*
            Create an application with a score, highscore and a highscorePlayer.
            Create a method which has two parameters, one for the score and one for the playerName.
            When ever that method is called, it should be checked if the score of the player is higher 
            than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is 
            " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " 
            could not be broken and is still held by " + highscorePlayer.
            Consider which variables are required globally and which ones locally.
             */

            //CheckHighScore(10, "JohnConnor");
            //Console.WriteLine();
            //CheckHighScore(101, "Mike23");

            // ==========================================================================================

            // =================================================
            // =============== Ternary Operator ================
            // =================================================

            // condition ? first_expression : second_expression;
            // condition has to be either true or false.
            // The conditional operator is right - associative.
            // The expression a ? b: (c ? d : e),
            // is evaluated as a ? b : (c ? d : e),
            // not as (a ? b : c) ? d: e.
            // The conditional operator cannot be overloaded.

            //int temperature = -5;
            //string stateOfMatter;

            //if (temperature < 0)
            //    stateOfMatter = "solid";
            //else
            //    stateOfMatter = "liquid";
            //Console.WriteLine("Using if statement");
            //Console.WriteLine("State of matter is {0}", stateOfMatter);
            //Console.WriteLine();

            //temperature += 30;
            //// using short if / ternary operator
            //stateOfMatter = temperature < 0 ? "solid" : "liquid";
            //Console.WriteLine("Using enhanced if (Ternary operator)");
            //Console.WriteLine("State of matter is {0}", stateOfMatter);
            //Console.WriteLine();

            //temperature += 100;
            //// challenge - add the gas state of matter to the options.
            //stateOfMatter = temperature > 0 && temperature < 100? "liquid" : "gas";
            //Console.WriteLine("Challenge. Add gas state of matter to options");
            //Console.WriteLine("State of matter is {0}", stateOfMatter);


            //// better way for challenge
            //stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            //Console.WriteLine("Challenge Improvement. Add gas state of matter to options");
            //Console.WriteLine("Temperature is {0}. state of matter is {1}",temperature, stateOfMatter);

            // ==========================================================================================

            // =================================================
            // ========= Challenge - Ternary Operator ==========
            // =================================================

            /*
             
            We have studied ternary operators and their usage so here is a small challenge for you. 
            Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.
            If the input value is not an integer value, it should print to the console "Not a valid Temperature".
            And if the input value is the valid integer then it should work as mentioned below.

            If input temperature value is <=15 it should write "it is too cold here" to the console.

            If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

            If the input temperature value is > 28 it should write "it is hot here" to the console.

            Make sure to use ternary operators and not if statements to check for the three conditions, 
            however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.

             */

            Console.Write("Please enter the temperature: ");
            string tempString = Console.ReadLine();
            bool isValid = int.TryParse(tempString, out int temperature);

            if(isValid)
            {
                Console.WriteLine(temperature > 28 ? "It's hot in here" : temperature <= 28 && temperature >=16 ? "It's an okay temperature." : "It's too cold in here");
            } else
            {
                Console.WriteLine("Not a valid temperature");
            }

            // ==========================================================================================
        }


        // Variables for the first if/else challenge
        static string registeredName;
        static string registeredPw;
        /// <summary>
        /// This function promts user to enter a new username and password and stores it in
        /// the static variables "registeredName" and "registeredPw"
        /// </summary>
        public static void Register()
        {
            Console.WriteLine("Register to create an account.");
            Console.WriteLine();
            Console.Write("Enter a new username: ");
            registeredName = Console.ReadLine();
            Console.Write("Enter a new password: ");
            registeredPw = Console.ReadLine();
            if (registeredName != "" && registeredPw != "")
            {
                Console.WriteLine("Registered successfully. Your username is {0}.", registeredName);
            }
            else if (registeredName == "" && registeredPw != "")
            {
                Console.WriteLine("Username is empty. Must enter a username to register.");
            }
            else if (registeredName != "" && registeredPw == "")
            {
                Console.WriteLine("Password is empty. Must enter a password to register.");
            }
            else
            {
                Console.WriteLine("Please provide a username and password to register.");
            }
        }

        /// <summary>
        /// This function prompts user to enter his username and password and validates against
        /// the static variables "registeredName" and "registeredPw" in order to assure a successful login.
        /// </summary>
        public static void LogIn()
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


        // Variables for second if/else challenge
        static int highScore = 100;
        static string highscorePlayer = "TimmyTurner21";

        /// <summary>
        /// Whenever that method is called, it should be checked if the score of the player is higher 
        /// than the highscore
        /// </summary>
        /// <param name="score"></param>
        /// <param name="playerName"></param>
        public static void CheckHighScore(int score, string playerName)
        {
            if (score < highScore)
            {
                Console.WriteLine("The old high score of {0} could not be broken and is still held by {1}", highScore, highscorePlayer);
            } else
            {
                highScore = score;
                highscorePlayer = playerName;
                Console.WriteLine("The new high score is {0}. \nNew high score holder is {1}", highScore, highscorePlayer);
            }
        }
    }
}
