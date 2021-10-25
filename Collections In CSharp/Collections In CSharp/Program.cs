using System;

namespace Collections_In_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // =========================================
            // =========== Basics of Arrays ============
            // =========================================

            // Arrays

            // Stores a fixed size sequential collection of elements.
            // ONLY of the same type
            // All kinds of types are allowed: int, string, object, etc.
            // Great to store a collection of data - Easier to think of a collection
            // of variables of the same type stored at contiguous memory locations.

            // =============================================
            // ========== Structure of an Array ============

            // Array Length: 6
            // Values:  [13, 15, 5, 7, 8, 1]
            // Indexes:   0,  1, 2, 3, 4, 5

            // Element at index 4 has a value of 8
            // =============================================
            // =========== Declaring an Array ==============

            // dataType[] arrayName;
            // int[] grades;

            // =============================================
            // ========== Initializing an array ============

            // dataType[] arrayName = new dataType[amountOfEntries];
            // int[] grades = new int[5];

            // =============================================
            // ======= Assigning values to an array ========

            // arrayName[index] = value;
            // grades[0] = 15;
            // grades[1] = 12;


            // =============================================
            // ====== Declaring and initializing Arrays ====
            // ====== and using the length property ========
            // =============================================

            // Declaring grades array
            //int[] grades = new int[5];

            //// Assigning values 
            //grades[0] = 20;
            //grades[1] = 15;
            //grades[2] = 12;
            //grades[3] = 9;
            //grades[4] = 7;

            //// Printing Array Values
            //Console.WriteLine("Grades at index 0: {0}: ",grades[0]);
            //Console.WriteLine("Grades at index 1: {0}: ", grades[1]);
            //Console.WriteLine("Grades at index 2: {0}: ", grades[2]);
            //Console.WriteLine("Grades at index 3: {0}: ", grades[3]);
            //Console.WriteLine("Grades at index 4: {0}: ", grades[4]);
            //Console.WriteLine();

            //// Another way of initializing an array.
            //int[] mathGrades = {13,4,23};
            //Console.WriteLine("mathGrade at index 0: {0}", mathGrades[0]);
            //Console.WriteLine();
            //Console.Write("Enter new mathGrade[0]: ");
            //string mathGrade0 = Console.ReadLine();
            //mathGrades[0] = int.Parse(mathGrade0);
            //Console.WriteLine("mathGrade at index 0: {0}", mathGrades[0]);
            //Console.WriteLine();

            //// Third way of initializing an array
            //int[] gradesOfStudents = new int[] {14,43,53,2,65};

            //Console.WriteLine("Length of gradesOfStudents Array: {0}", gradesOfStudents.Length);


            // =============================================
            // ========= Arrays and ForEach Loops ==========
            // =============================================

            //int[] nums = new int[10];

            //// Risking an index out of bounds error
            //for(int i = 0; i < 10; i++)
            //{
            //    nums[i] = i;
            //    Console.WriteLine("Element {0}: {1}",i,nums[i]);
            //}

            //Console.WriteLine();

            //// Solutions for IndexOutOfBound exceptions.

            //// 1. Use the array.length property.
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //    Console.WriteLine("Element {0}: {1}", i, nums[i]);
            //}

            //Console.WriteLine();

            //int counter = 0;
            //// 2. Using forEach loop.
            //foreach (int num in nums)
            //{
            //    Console.WriteLine("Element {0}: {1}", counter, num);
            //    ++counter;
            //}

            // Challenge: 
            // Create an array with 5 of your best friends.
            // Create a foreach loop that greets all five of them.

            //string[] friends = { "Mike", "Soto", "Cestero", "Negrón", "Castro"};
            //foreach (string name in friends)
            //{
            //    Console.WriteLine("Hello, {0}", name);
            //}


            // =============================================
            // ======= Arrays and Switch Challenge =========
            // =============================================

            /*
            Foreach Loops and Switch Statement challenge
            Create an application that takes 2 input values.

            Any input value (1st input)
            Asks the data type of the input value. (2nd input)
            It will print to the console the options like below to take input for the 2nd input value:

            Press 1 for String
            Press 2 for integer
            Press 3 for Boolean

            If the input value for the 2nd input is 1 then the application should check that 
            if the entered 1st input is a valid string or not. Hereby we even want to check, 
            if it is a complete alphabetic entry (so no numbers accepted).

            If the input value for the 2nd input is 2 then the application should check 
            if the entered 1st input is a valid integer or not.

            Based on the input the 1st value and the selection of data type using the 2nd input, 
            the application should return whether the entered 1st value is of data type selected by the user or not.

            Please make sure to use a switch statement. To check the valid string you can write your custom logic.

            For example:

            Enter a value: {here you can enter any value}
            Select the Data type to validate the input you have entered.
            Press 1 for String
            Press 2 for Integer
            Press 3 for Boolean
            Here, if you enter 1 it should return below message
            You have entered a value: Denis Panjuta
            It is a valid: String
            Here, if you enter 2 it should return below message
            You have entered a value: Denis Panjuta
            It is an invalid: Integer
             */

            //bool valid;
            //Console.Write("Enter any value: ");
            //string value = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Select a Data Type to validate the input you have entered.");
            //Console.WriteLine("Press 1 for String");
            //Console.WriteLine("Press 2 for Integer");
            //Console.WriteLine("Press 3 for Boolean");
            //Console.WriteLine();
            //Console.Write("Option: ");
            //string option = Console.ReadLine();
            //bool isNumber = int.TryParse(option, out int intOption); ;

            //if(isNumber)
            //{
            //    switch (intOption)
            //    {
            //        case 1:
            //            Console.WriteLine("Checking if input is a valid string");
            //            valid = IsAllAlphabetic(value);
            //            if (valid)
            //                Console.WriteLine("Value {0} is a valid string", value);
            //            else
            //                Console.WriteLine("Value {0} is not a valid string", value);
            //            break;
            //        case 2:
            //            Console.WriteLine("Checking if input is a valid integer");
            //            valid = int.TryParse(value, out int intVal);
            //            if(valid)
            //                Console.WriteLine("Value {0} is a valid Integer", intVal);
            //            else
            //                Console.WriteLine("Value {0} is not a valid Integer", value);
            //            break;
            //        case 3:
            //            Console.WriteLine("Checking if input is a valid boolean");
            //            valid = bool.TryParse(value, out bool boolVal);
            //            if (valid)
            //                Console.WriteLine("Value {0} is a valid Boolean", boolVal);
            //            else
            //                Console.WriteLine("Value {0} is not a valid Boolean", boolVal);
            //            break;
            //        default:
            //            Console.WriteLine("Please enter an option between 1 and 3.");
            //            break;
            //    }

            //} else
            //{
            //    Console.WriteLine("Option must be an integer between 1 and 3.");
            //}

            // =============================================
            // ======== Multi Dimentional Arrays ===========
            // =============================================

            // Declare a 2D array
            //string[,] matrix;

            //// Declare a 3d array
            //int[,,,] threeDimensionalArray;

            //// Two dimensional array
            //int[,] array2D = new int[,]
            //{
            //    {1,2,3},
            //    {4,5,6},
            //    {7,8,9},
            //};

            //// Accessing row with index 1, column with index 1.
            //Console.WriteLine(array2D[1,1]);

            //// Challenge: try to access the 7.
            //Console.WriteLine(array2D[2, 0]);

            //// Creating a 3D array.
            //string[,,] array3D = new string[,,]
            //{ // Depth (First Index)
            //    { // Height(Second Index)
            //        {"000", "001"}, // Length (Third Index)
            //        {"010", "011"},
            //        {"Hi there", "What's Up"},
            //    },
            //    {
            //        {"100", "101"},
            //        {"110", "111"},
            //        {"Another One", "Last Entry"},
            //    }
            //};

            //// Accessing a 3D array
            //Console.WriteLine("Accessing 3D array: {0}", array3D[0,2,1]);

            // Other ways of declaring a multidimensional array
            //string[,] array2DString = new string[3, 2] { { "One", "Two" }, { "Three", "Four" }, { "Five", "Six" } };

            //// Challenge: Try to change the text "Four" into another string.

            //Console.WriteLine("Value at index 1,1: {0}", array2DString[1, 1]);
            //array2DString[1, 1] = "Chicken";
            //Console.WriteLine("Value at index 1,1: {0}", array2DString[1,1]);

            //// Find out 2d array dimensions. (1D array returns 1, 2D array returns 2, 3D array returns 3)
            //int dimensions = array2DString.Rank;
            //Console.WriteLine("Number of dimensions for array2DString: {0}", dimensions);

            //// Create an array without specifying the rank:
            //int[,] array2D = { { 1, 2 }, { 3, 4 } };

            // =============================================
            // ======= Nested For Loops and 2D Arrays ======
            // =============================================

            int[,] matrix = 
            {
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };

            // Iterating through matrix using a foreach loop
            //foreach (int num in matrix)
            //{
            //    Console.Write(num+" ");
            //}

            // Iterating through matrix using nested for loops.
            Console.WriteLine("Printing 2d array.");
            // Nested for loop
            // Outer for loop
            for(int i = 0; i<matrix.GetLength(0); i++)
            { // The GetLength method prints the length of the specified array dimension.
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Printing odd numbers only: ");
            // Adjust the code below so that the for loop only prints out odd numbers
            for (int i = 0; i < matrix.GetLength(0); i++)
            { // The GetLength method prints the length of the specified array dimension.
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] % 2 != 0 ? matrix[i, j] + " " : "");
                }
                //Console.WriteLine();
            }
            Console.WriteLine();

            // =============================================
            // == Nested For Loops and 2D Arrays Examples ==
            // =============================================
            Console.WriteLine();
            // How to print out the diagonal elements of a 2D array
            // i must equal j
            Console.WriteLine("Printing out the diagonal elements in an array: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(i == j ? matrix[i, j] + " " : " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Now print the diagonal elements with only one for loop
            Console.WriteLine("Printing out the diagonal elements in an array using only one for loop: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, i] + " \n");
            }

            Console.WriteLine();


            // Now try to print the other diagonal elements from right to left
            Console.WriteLine("Printing out the right-to-left diagonal elements in an array: ");
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                    Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// This function checks if the input string is a pure alphabetical string.
        /// Method is part of the  foreach / switch statement challenge.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
