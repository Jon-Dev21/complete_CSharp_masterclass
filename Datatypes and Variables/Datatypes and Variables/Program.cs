using System;

namespace Datatypes_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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


            // ============== USING / INITIALIZING VARIABLES ============== 

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
        }
    }
}
