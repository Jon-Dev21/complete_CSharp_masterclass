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
            /*
            // ==  Explicit conversions (float to int, double to int, etc)==
            double myDouble = 13.53;
            int myInt;

            // Cast double to int (Cuts the decimal point. Does not round it):
            myInt = (int) myDouble;
            Console.WriteLine(myInt);

            // == Implicit conversion (From Bigger types to smaller types)==
            int num = 12345667;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            // Type Conversion
            
            // From double to string
            string myString = myNewDouble.ToString();
            Console.WriteLine(myString);
            // From bool to string
            bool sunIsShining = true;
            Console.WriteLine(sunIsShining.ToString());


            // Challenge. Convert myFloat into a string.
            string myFloatString = myFloat.ToString();
            Console.WriteLine(myFloatString);
            */

            // ============================================================
            // ================ Parsing string to Integer =================
            // ============================================================
            /*
            string myString = "15";
            string mySecondString = "13";
            string result = myString + mySecondString; // Concatinates string instead of adding.

            // Converting string to int
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int res = num1 + num2;
            Console.WriteLine(res);
            */

            // ============================================================
            // =================== String Manipulation ====================
            // ============================================================
            /*
            int age = 31;
            string name = "Alfonso";
            string profession = "Software Developer"; // Challenge variable

            // 1. String Concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello. My name is "+name+", I am "+age+ " years old.");
            Console.WriteLine();
            // 2. String Formatting (Challenge. Create 3rd variable to use.)
            // String formatting uses indexes starting at 0 for variables.
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello. My name is {0}, I am {1} years old and I am a {2}.", name, age, profession);
            Console.WriteLine();
            // 3. String Interpolation
            // String interpolation uses $ at the start which will allow you to write 
            // your own variables inside of the string placed in curly brackers. {variable}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello. My name is {name}, I am {age} years old and I am a {profession}.");
            Console.WriteLine();
            // 4. Verbatim Strings
            // Verbatim strings start with @ and tells the compiler to take the string literally
            // and ignore any spaces and escape characters like \n, \t, etc.
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque 
            laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta 
            sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur 
            magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit 
            amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
            quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut 
            aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae 
            consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?");
            */

            // ============================================================
            // ===================== String Methods =======================
            // ============================================================

            // Substring(int32) - Used to get substring from string, starting from specified index.

            // ToLower() - Used to convert string to lowercase

            // ToUpper() - Used to convert string to uppercase

            // Trim() - Removes all leading and trailing white spaces from string.

            // IndexOf(string) - returns the first occurence of the string or character inside a string.

            // IsNullOrWhitespace - returns true if string is either null or blank, else returns false.

            // string.Concat(string, string, string) - concatinates all the comma separated strings passed inside the parameters. 

            // String.Format - used to insert object or variable value inside a string.
            // With String.Format we can replace the value in the specified format.
            // Syntax: String.Format("any string {index}", object);
            // Example:
            // var name = "John"
            // String.Format("My name is {0}., name); name is replaced by {0}
            // Output will be "My name is John."

            // ============================================================
            // =================== String Challenge =======================
            // ============================================================

            /*
             * Challenge 1 – String and its methods
            Now you know the use of various string functions so let’s create a small Console application to practice this.
            Declare a string variable and don’t assign any value to it.
            Print on the console “Please enter your name and press enter”. 
            You can then enter your name or any other valid string like “tutorials.eu”.
            Assign that entered string to the string variable which you have declared initially.
            The program should write on the console that string in Uppercase in the first line, 
            then the same string in Lowercase in the second line. In the third line, it writes 
            on the console the string with no trailing or preceding white space like if string entered 
            as “ tutorials.eu ” it should be written on the console as “tutorials.eu”. 
            And in the last line, it should write the Substring of the entered string on the console.
            These kinds of features are e.g. used when creating a login screen, where the system will 
            cut out trailing or preceding white space or, doesn’t care about the casing of the entered username.
             

            // Challenge Area
            string name = "";
            Console.Write("Please enter your name and press enter: ");
            name = Console.ReadLine();
            Console.WriteLine("Uppercase name: {0}",name.ToUpper());
            Console.WriteLine("Lowercase name: {0}", name.ToLower());
            Console.WriteLine("Trimming name: {0}", name.Trim());
            Console.WriteLine("Substring of name: {0}", name.Substring(0,8));
            */

            // ============================================================
            // ================== String Challenge 2 ======================
            // ============================================================

            /*
             Let’s create another console application for more practice.
            This application asks the user to input a string in the first line like “Enter a string here: ”.
            In the Second Line, it should ask for the character to search in the string which you have entered 
            in the first line like “Enter the character to search: ”
            On the third line, it should write the index of the first occurrence of the searched character from the string.
            Now on concatenation...
            It should then ask to enter the first name and once the name is written and the enter button is pressed, 
            it should ask to enter the last name.
            It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". 
            Output can be different in your case. Try to store the full name in a variable, before displaying it.             
             

            Console.Write("Enter a string here: ");
            string input = Console.ReadLine();
            Console.Write("Enter the character to search for: ");
            char searchKey = Console.ReadLine()[0];                     // With the square bracket, i get the first letter of the string
            Console.WriteLine("Searching for {0} in string \"{1}\". Index: {2}",searchKey,input, input.ToLower().IndexOf(searchKey.ToString().ToLower()));
            Console.WriteLine();
            Console.WriteLine("Concatenation part");
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(string.Concat("Your full name is ",firstName, " ", lastName, "."));
            */

            // ============================================================
            // ========== Datatypes and Variables Challenge ===============
            // ============================================================
            /*
            Now that you know how to declare and initialize Variables, please go ahead and create 
            a variable for each of the primitive datatypes (you can find the list here: 
            https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)?redirectedfrom=MSDN). 
            Leave the Object datatype out. And also please initialize each variable with a working value.
            Then create two values of type string. 
            The first one should say "I control text"
            The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.
            Add each an output for each of the variables and write it onto the console. (WriteLine)
            Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours.
            Have fun :)

            int integer = 10;
            byte byteNum = 255;
            long longnum = 1345134141374245713;
            short shortNum = 23134;
            sbyte sByteNum = 14;
            bool isPrimitive = true;
            float floatNum = 1343.43F;
            double doubleNum = 1413534.4412133;
            decimal decimalNum = 1345.53M;
            string text = "I Control Text";
            string textNumber = "134243";
            var parsedNum = Int32.Parse(textNumber);

            Console.WriteLine("Printing integer: {0}", integer);
            Console.WriteLine("Printing byte: {0}", byteNum);
            Console.WriteLine("Printing long: {0}", longnum);
            Console.WriteLine("Printing short: {0}", shortNum);
            Console.WriteLine("Printing sbyte: {0}", sByteNum);
            Console.WriteLine("Printing bool: {0}", isPrimitive);
            Console.WriteLine("Printing float: {0}", floatNum);
            Console.WriteLine("Printing double: {0}", doubleNum);
            Console.WriteLine("Printing decimal: {0}", decimalNum);
            Console.WriteLine("Printing text string: {0}", text);
            Console.WriteLine("Printing number string: {0}", textNumber);
            Console.WriteLine("Printing parsed number string plus 100000: {0}", parsedNum+100000);
            */

            // ============================================================
            // ======================= Constants ==========================
            // ============================================================
            /*
            const double PI = 3.14159265359;
            const int weeks = 52, months = 12;

            // Create constant of type string with a birthday.
            const string birthday = "12-11-1985";
            */
        }
    }   
}
