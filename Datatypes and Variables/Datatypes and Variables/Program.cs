using System;

namespace Datatypes_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ Numeric Data Types ------------

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

            /*
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
        }
    }
}
