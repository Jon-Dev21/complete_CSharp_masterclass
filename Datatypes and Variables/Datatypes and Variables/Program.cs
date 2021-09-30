using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // ============================================================
            // ==================== Numeric Data Types ====================
            // ============================================================

            int age = 15;
            Console.WriteLine("Age is {0}", age);
            Console.WriteLine("Age is an integer variable. Integers can range from -2,147,483,648 to 2,147,483,648");
            Console.WriteLine();
            
            short xshort = 30000;
            Console.WriteLine("This is a short: " + xshort);
            Console.WriteLine("short can range from -32767 to 32767");
            Console.WriteLine();
            
            sbyte xbyte = 127;
            Console.WriteLine("This is an sbyte: " + xbyte);
            Console.WriteLine("sbytes can range from -128 to 127");
            Console.WriteLine();

            long xlong = 9000000000000000000;
            Console.WriteLine("This is a long: " + xlong);
            Console.WriteLine("long can range from -9,223,327,036,854,775,808 to -9,223,327,036,854,775,808");
            Console.WriteLine();

           // ------------Decimal Point Data Types ------------

           // float is mostly used in graphics libraries (high demand processing power)
           float xfloat = 99.99f;
            Console.WriteLine("This is a float: " + xfloat);
            Console.WriteLine("float can range from 1.5 x 10^-45 to 3.4 x 10^38. It has a 7 digit precision");
            Console.WriteLine();

            // double is mostly used for real world values (except money calculations)
            double xdouble = 1.554818661822545;
            Console.WriteLine("This is a double: " + xdouble);
            Console.WriteLine("double has a 15 digit precision");
            Console.WriteLine();
            
            // decimal is mostly used in financial applications (high level of accuracy)
            decimal xdecimal = 1.54584816584861354654684316848M;
            Console.WriteLine("This is a decimal: " + xdecimal);
            Console.WriteLine("decimal has a 28 digit precision");
            Console.WriteLine();

            // boolean. Used to store only true or false.
            bool Switch = false;
            Console.WriteLine("Boolean values store either true or false. 1 = true or 0 = false");
            Console.WriteLine("Are you done with the course? " + Switch);
            Console.WriteLine();

            // char
            char letter = 'A';
            Console.WriteLine("Char data types store a single character literal or unicode");
            Console.WriteLine("First letter of the alphabet? " + letter);
            Console.WriteLine();

            // string
            string username = "Jon-Dev21";
            Console.WriteLine("Strings can store multiple letters and unicodes");
            Console.WriteLine("Username: "+username);
            Console.WriteLine();


            // Messing with booleans
            bool isDone = false;
            Console.WriteLine("Hello Bro. Are you done? ");
            //isDone = !isDone;
            if (isDone)
            {
                Console.WriteLine(isDone+". I\'m not done.");
            } else
            {
                Console.WriteLine(isDone + ". I\'m done.");
            }
            
            */

            // ============================================================ 
            // ============== USING / INITIALIZING VARIABLES ============== 
            // ============================================================

            /*
            // Declaring an integer
            int num1;
            
            // assigning value to a variable
            num1 = 300;
            
            // Declaring and initializing variable at the same time.
            int num2 = -100;
            
            // Adding num1 + num2
            Console.WriteLine(num1+num2);

            //Console.Read();

            // using concatenation
            Console.WriteLine("Num1 = "+num1);
            Console.WriteLine("Num2 = "+num2);
            Console.WriteLine("Num1 + Num2 = "+(num1+num2));

            // Creating multiple variables at once
            int num3 = 4, num4=12, num5=124;
            Console.WriteLine("Adding "+num3+ ", "+num4+", "+num5+": "+ (num3+num4+num5));

            double d1 = 3.1415;
            double d2 = 5.1;
            Console.WriteLine();
            Console.WriteLine("Double Division: {0} / {1} = {2}",d1,d2,d1/d2);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            Console.WriteLine();
            Console.WriteLine("Float Division: {0} / {1} = {2}", f1, f2, f1 / f2);

            long longNum = 416854321845312514;
            long longNum2 = 5658419684135156;
            Console.WriteLine();
            Console.WriteLine("Adding long numbers: "+(longNum+longNum2));

            long longNum3 = 486465163854;
            int iNum2 = 12213;
            Console.WriteLine();
            Console.WriteLine("Adding long and int numbers: " + (longNum3 + iNum2));

            double d4 = 10.6;
            int inum3 = 3;
            Console.WriteLine();
            Console.WriteLine("Dividing double and int: " + (d4 / inum3));

            Console.WriteLine();
            Console.WriteLine("Dividing int and double: " + (inum3 / d4));
            */


            // ============================================================
            // ========================= Strings ==========================
            // ============================================================

            // Capital S in String invokes the string class.
            // Lowercase string just refers to the string variable.

            /*
            string myName = "John";
            Console.WriteLine("My name is {0}", myName.ToUpper());
            */

            // ============================================================
            // ==================== Coding Standards ======================
            // ============================================================

            // 1. Always give your variables a reasonable name. Name must be related to the variable's use.
            // 2. Always give your function a reasonable name. Name must be related to the function's use.
            // 3. Always comment your code. Make comments as descriptive as possible. There are three types of comments:
            //      - // Single line comments (double slash)
            //      - /* MultiLine comments (slash and asterisk)
            //      -  <summary> XML Comments </summary> (start with 3 slashes).
            //         Useful when describing variables and methods. When hovering on an xml commented method, the summary will appear.

            // ============================================================
            // ============== Value Type vs Reference Type ================
            // ============================================================

            // Value Types:

            // Value types are data types which holds values directly on it's own memory space.
            // Value types use heaps to store the values.
            // Value types include int, float, long, double, char, bool, decimal double, etc.

            // Reference Types: 

            // Reference Types are types that instead of storing values in memory directly,
            // stores the memory location of the actual data.
            // Reference types include string, class, Array, etc.

            // ============================================================
            // ==================== Console Methods =======================
            // ============================================================

            // Exploring console class methods.

            /*
            Console.Write("Console.Write() prints text and keeps the cursor on the same line");
            Console.WriteLine("Console.WriteLine() prints text and puts the cursor in the next line");
            Console.Read() - Takes a single input of type string and returns the ASCII value of that input. (ASCII Stands for American Standard Code for Information Interchange)
            Console.ReadLine() - Takes a string or integer and returns it as the Output value. 
            Console.ReadKey() - Takes a single input of type string and returns the Key info

            */

            // Testing Console methods
            /*
            Console.Write("Enter some input: ");
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Entered Input: {0}", input);
            Console.WriteLine();
            Console.Write("Enter a string and press enter: ");
            int ASCIIVal = Console.Read();
            Console.WriteLine("The ASCII value is {0}", ASCIIVal);

            For more methods, check the Microsoft Docs: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=net-5.0
            */

            // ============================================================
            // ============= Changing Console Methods =====================
            // ============================================================

            /*
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.Title = "I am the title";
            Console.WriteLine("I'm Blue. Dabadee dabadaaaiii");
            */

            // ============================================================
            // ========= Naming Conventions and Coding Standards ==========
            // ============================================================

            // When declaring a class or method you should use Pascal Casing (Each word starts with a capital letter.
            // Class name example: ClientActivity.
            // Method name example: CalculateValue.

            // For method arguments, you should use camel casing:
            // Method argument name example: firstNumber

            // Try to avoid underscores in variable names with an exception to the beginning.

            // Correct
            //string myName;
            //int lastNum;
            //bool isSaved;
            //string _firstName

            // Avoid
            // String myName
            // Int32 lastNum
            // Boolean isSaved
            // string first_name

            // For more coding standards, visit: https://dofactory.com/csharp-coding-standards

            // ============================================================
            // ============ Implicit and Explicit Conversions =============
            // ============================================================

        }
    }
}
