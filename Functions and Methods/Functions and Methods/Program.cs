using System;

namespace Functions_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // ====================================================
            // ================ Methods Overview ==================
            // ====================================================

            // A method is a code block that contains a series of statements.
            // A program causes the statements to be executed by calling the method and
            // Specifying required method arguments. In C#, every executed instruction is performed
            // In the context of a method. The Main Method is the entry point for every C# application
            // and it's caled by the Common language runtime (CLR) when the program is started.

            /*
             <Access Specifier> <Return Type> <Method Name>(Parameter List) {
               Method Body
            }
            Following are the various elements of a method −

            Access Specifier − This determines the visibility of a variable or a method from another class.

            Return type − A method may return a value. The return type is the data type of the value the method returns. 
            If the method is not returning any values, then the return type is void.

            Method name − Method name is a unique identifier and it is case sensitive. 
            It cannot be same as any other identifier declared in the class.

            Parameter list − Enclosed between parentheses, the parameters are used to pass and receive data from a method. 
            The parameter list refers to the type, order, and number of the parameters of a method. Parameters are optional; 
            that is, a method may contain no parameters.

            Method body − This contains the set of instructions needed to complete the required activity.
             */


            // ====================================================
            // ================== Void Methods ====================
            // ====================================================

            //WriteSomething();
            //Console.Write("Give me some input: ");
            //string text = Console.ReadLine();
            //WriteSomethingSpecific(text);

            // ====================================================
            // ===== Methods with return value and parameters =====
            // ====================================================
            /*
            Console.Write("Enter a number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter another number: ");
            string num2 = Console.ReadLine();
            Console.WriteLine("Sum of {0} + {1} = {2}",num1,num2,Add(Int32.Parse(num1), Int32.Parse(num2)));
            Console.WriteLine("Multiplication of {0} * {1} = {2}", num1, num2, Multiply(Int32.Parse(num1), Int32.Parse(num2)));
            Console.WriteLine("Now for division:");
            Console.Write("Enter a decimal number: ");
            string num3 = Console.ReadLine();
            Console.Write("Enter another decimal number: ");
            string num4 = Console.ReadLine();
            Console.WriteLine("Division of {0} / {1} = {2}", num3, num4, Divide(double.Parse(num3), double.Parse(num4)));
            */

            // ====================================================
            // ============== Challenge  Method 1 =================
            // ====================================================

            /*
            In this challenge you will deepen your understanding for methods.
            Please go ahead and create three variables with names of your friends.
            Then create a Method "GreetFriend" which writes something like: 
            "Hi Frank, my friend!" onto the console, once it is called.
            Where "Frank" should be replaced with the Name behind the argument 
            given to the Method when it's called. So the method will need a parameter 
            (decide which DataType will be best). Greet all your three friends.
            */
            //GreetFriends("Doug", "Jose", "Mike");

            // ====================================================
            // ================ Using User Input ==================
            // ====================================================
            // Got ahead of myself and used user input in earlier challenges.
            // But will follow the tutorial here.
            /*Console.WriteLine("Entering Calculator mode... ");
            Console.WriteLine();
            Console.WriteLine(Calculate());
            */

            // ====================================================
            // =========== Try, Catch and Finally =================
            // ====================================================

            // Intentionally creating errors.

            //Console.Write("Please enter a number: ");
            //string input = Console.ReadLine();
            //try
            //{
            //    // I want to try this code and avoid my program from crashing.
            //    int inputAsNum = int.Parse(input);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format Exception. Enter the correct type next time.");
            //    //throw;
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Overflow Exception. Number was too long or short for an int32.");
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Argument Null Exception. Number was too long or short for an int32.");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Something went wrong.");
            //}
            //finally
            //{
            //    Console.WriteLine("This finally block is called anyways!");
            //}

            // -----------------------------------------------------------------------

            // Little challenge. Divide by 0 try
            //int num1 = 12;
            //int num2 = 0;
            //int result;
            //try
            //{
            //    result = num1/num2;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by 0");
            //}
            //Console.ReadKey();

            // ====================================================
            // =================== Operators ======================
            // ====================================================
            /*
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;       // The - operator multiplies number by -1.
            Console.WriteLine("Num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it Sunny? {0}", !isSunny);    // the ! operator can convert true values to false.

            // Increment Operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);         // Post Increment
            Console.WriteLine("num is {0}", ++num);         // Pre Increment

            // Decrement Operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);         // Post Decrement
            Console.WriteLine("num is {0}", --num);         // Pre Decrement

            // Regular Operators: 
            int result;

            result = num1 + num2;
            Console.WriteLine("Result of {0} + {1} = {2}",num1, num2, result);
            result = num1 - num2;
            Console.WriteLine("Result of {0} - {1} = {2}", num1, num2, result);
            result = num1 * num2;
            Console.WriteLine("Result of {0} * {1} = {2}", num1, num2, result);
            result = num1 / num2;
            Console.WriteLine("Result of {0} / {1} = {2}", num1, num2, result);
            result = num1 % num2;
            Console.WriteLine("Result of {0} % {1} = {2}", num1, num2, result);

            // Relational and Type Operators
            bool isLess;
            isLess = num1 < num2;
            Console.WriteLine("Result of {0} < {1} is {2}",num1,num2,isLess);

            bool isGreater;
            isGreater = num1 > num2;
            Console.WriteLine("Result of {0} > {1} is {2}", num1, num2, isGreater);

            // Equality Operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of {0} == {1} is {2}", num1, num2, isEqual);

            bool isNotEqual;
            isNotEqual = num1 != num2;
            Console.WriteLine("Result of {0} != {1} is {2}", num1, num2, isNotEqual);

            // Conditional Operators
            // AND && operator true if both premises are true.
            bool isLessAndSunny;
            isLessAndSunny = isLess && isSunny;
            Console.WriteLine("Result of isLess = {0} and isSunny {1} = {2}", isLess, isSunny, isLessAndSunny);

            // OR || operator true if either one of the premises is true. (If both false, result is false) 
            bool isLessOrSunny;
            isLessOrSunny = isLess || isSunny;
            Console.WriteLine("Result of isLess = {0} or isSunny {1} = {2}", isLess, isSunny, isLessOrSunny);
            */


        }

        // =================== Void methods ===================
        /// <summary>
        /// This method just prints some text.
        /// access modifier (static) return type method name (parameter1, parameter2)
        /// </summary>
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from the method, WriteSomething()");
        }

        /// <summary>
        /// This method prints the text passed as a string argument.
        /// </summary>
        /// <param name="text"></param>
        public static void WriteSomethingSpecific(string text)
        {
            Console.WriteLine("User wrote: {0}",text);
        }
        // ================ End of Void methods ================

        // ===== Methods with return value and parameters =====
        /// <summary>
        /// This method adds the 2 numbers passed. (classic)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// This method multiplies the 2 numbers passed. (classic)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// This method divides the 2 numbers passed. (classic)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        // ================ User input method ================
        /// <summary>
        /// This method asks for 2 integers as strings, parses them as integers and returns their sum.
        /// </summary>
        /// <returns>sum of both numbers.</returns>
        public static int Calculate()
        {
            Console.Write("Enter a number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter another number: ");
            string num2 = Console.ReadLine();
            Console.Write("Sum of {0} + {1} is equal to ", num1, num2);
            return Int32.Parse(num1) + Int32.Parse(num2);
        }
        // === Methods with return value and parameters end ====

        // ============== Challenge Method 1 ===================
        /// <summary>
        /// This method takes in 3 friend's names and prints greetings for each of them.
        /// </summary>
        /// <param name="friend1"></param>
        /// <param name="friend2"></param>
        /// <param name="friend3"></param>
        public static void GreetFriends(string friend1, string friend2, string friend3)
        {
            Console.WriteLine("Hi {0}, my bro!", friend1);
            Console.WriteLine("Hi {0}, my best friend!", friend2);
            Console.WriteLine("Hi {0}, my partner in crime!", friend3);
        }
    }
}
