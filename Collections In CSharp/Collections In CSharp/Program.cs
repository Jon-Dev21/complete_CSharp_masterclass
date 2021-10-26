using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

            //int[,] matrix = 
            //{
            //    {1,2,3},
            //    {4,5,6},
            //    {7,8,9},
            //};

            // Iterating through matrix using a foreach loop
            //foreach (int num in matrix)
            //{
            //    Console.Write(num+" ");
            //}

            // Iterating through matrix using nested for loops.
            //Console.WriteLine("Printing 2d array.");
            //// Nested for loop
            //// Outer for loop
            //for(int i = 0; i<matrix.GetLength(0); i++)
            //{ // The GetLength method prints the length of the specified array dimension.
            //    // inner for loop
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("Printing odd numbers only: ");
            //// Adjust the code below so that the for loop only prints out odd numbers
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{ // The GetLength method prints the length of the specified array dimension.
            //    // inner for loop
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] % 2 != 0 ? matrix[i, j] + " " : "");
            //    }
            //    //Console.WriteLine();
            //}
            //Console.WriteLine();

            //// =============================================
            //// == Nested For Loops and 2D Arrays Examples ==
            //// =============================================
            //Console.WriteLine();
            //// How to print out the diagonal elements of a 2D array
            //// i must equal j
            //Console.WriteLine("Printing out the diagonal elements in an array: ");
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(i == j ? matrix[i, j] + " " : " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //// Now print the diagonal elements with only one for loop
            //Console.WriteLine("Printing out the diagonal elements in an array using only one for loop: ");
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    Console.Write(matrix[i, i] + " \n");
            //}

            //Console.WriteLine();


            //// Now try to print the other diagonal elements from right to left
            //Console.WriteLine("Printing out the right-to-left diagonal elements in an array: ");
            //for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            //{
            //        Console.Write(matrix[i, j] + " ");
            //}

            //Console.WriteLine();


            // =============================================
            // =============== Jagged Arrays ===============
            // =============================================

            // Storing an array within an array
            // Declaring jagged array
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[5];
            //jaggedArray[1] = new int[3];
            //jaggedArray[2] = new int[2];

            //// Assigning values to jagged array.
            //jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            //jaggedArray[1] = new int[] { 1,2,3 };
            //jaggedArray[2] = new int[] { 13,21 };

            //// Alternative way to assign value to jagged array.
            //int[][] jaggedArray2 = new int[][]
            //{
            //    new int[] { 2, 3, 5, 7, 11 },
            //    new int[] { 1,2,3 },
            //    new int[] { 13,21 }
            //};
            //Console.WriteLine("Accessing 5 in JaggedArray2: {0}", jaggedArray2[0][2]);

            //for(int i = 0; i<jaggedArray2.Length; i++)
            //{
            //    for(int j = 0; j<jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray2[i][j]+ ", ");
            //    }
            //    Console.WriteLine();
            //}

            // =============================================
            // ========== Jagged Arrays Challenge ==========
            // =============================================

            // Create a jagged array which contains 3 friends arrays in which 2 family members should be stored.
            // Introduce family members from different families to each other via the console.

            //string[][] friends = new string[][] {
            //    new string[] {"Tim", "Tim's Mom", "Tim's Dad" },
            //    new string[] {"Jim", "Jim's Mom", "Jim's Dad" },
            //    new string[] { "Tom", "Tom's Mom", "Tom's Dad" }
            //};

            //Console.WriteLine("{0}. Meet {1} and {2}",friends[0][0], friends[1][1], friends[1][2] );
            //Console.WriteLine("{0}. Meet {1} and {2}", friends[1][0], friends[2][1], friends[2][2]);
            //Console.WriteLine("{0}. Meet {1} and {2}", friends[2][0], friends[0][1], friends[0][2]);

            // =============================================
            // ======== Using Arrays as Parameters =========
            // =============================================

            //double[] grades = { 70, 34, 70, 83, 30, 70, 80, 95, 92, 91 };
            //Console.WriteLine("Average Grade: {0}",GetAverage(grades));


            // Challenge - Create an array of happiness in the main method and assign 5 values to it.
            // Create a method which has an array of type int as its parameter.
            // This method should increase the argument given by 2 for each entry.
            // Call this method in the main method and use "happiness" as the argument.
            // Create a foreach loop in the main method to write all values onto the console.

            //int[] happiness = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Happiness Array before increase.");
            //foreach (int value in happiness)
            //{
            //    Console.WriteLine(value);
            //}
            //increaseByTwo(happiness);
            //Console.WriteLine("Happiness Array after increase.");
            //foreach (int value in happiness)
            //{
            //    Console.WriteLine(value);
            //}

            // =============================================
            // ============ The Params Keyword =============
            // =============================================

            //Console.WriteLine("price is {0}, pi is {1}, at is {2}",32, 3.1, '@');

            //Console.WriteLine("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}={8}",1,2,3,4,5,6,7,9,1+2+3+4+5+6+7+9);

            //Console.WriteLine();

            // Creating example of using params. params lets us use as many parameters as desired.

            //string[] sentence = { "This", "is", "a", "long", "string.", "I", "have","no","idea","when","it","will","end."};

            //ParamsMethod(sentence);

            //int price = 50;
            //float pi = 3.14f;
            //char at = '@';
            //string book = "The Hobbit";
            //ParamsMethod2(price, pi, at, book);


            // Params is used to allow the freedom of passing multiple parameters.

            // =============================================
            // == Params Real World example using Math.Min =
            // =============================================

            // Returns the smallest number in a collection of numbers.
            // Math.Min(); 

            // Console.WriteLine("The minimum value is {0}", MinValue(1234,613,6341,234,51,52,5123,553,21,32,-231,5321,3,-341,-53,13,-3153,-134,51,513,-453));


            // =============================================
            // ==== Generic and Non-Generic Collections ====
            // =============================================

            // Collections are classes that we can use to store a collection of objects.
            // Not limited by one type of object.
            // No size constraints. It can grow in size as we add more elements.

            // Why do we need collections?
            // We use them to store, manage and manipulate groups of objects more efficiently e.g.
            // Adding, Deleting, Replacing, Searching, Copying Objects.

            // There are 2 different type of collections.

            // - Non-Generic
            // Can store any type of objects
            // Located in Systems.Collections namespace

            // Examples:

            // int num = 5
            // float num2 = 3.14f;
            // string name = "Denis"

            // declaring an array list
            // ArrayList myArrList = new ArrayList();

            // Adding values to array list
            // myArrList.Add(num1);
            // myArrList.Add(num2);
            // myArrList.Add(name);

            // Go through all the elements in the ArrayList.
            // foreach (object element in myArrList) {
            //      Console.WriteLine(element+" ");
            // }



            // - Generic
            // Limited to one type of object
            // Located in Systems.Collections.Generic namespace

            // Example

            // string animal1 = "Cat";
            // string animal1 = "Dog";
            // string animal1 = "Flamingo";

            // List<string> myList = new List<string>();

            // =============================================
            // ============== Array Lists ==================
            // =============================================

            // Declaring an ArrayList with undefined amount of objects.
            //ArrayList myArrayList = new ArrayList();

            //// Declaring an ArrayList with defined amount of objects.
            //ArrayList myArrayList2 = new ArrayList(100);

            //// Adding elements to myArrayList
            //myArrayList.Add(25);
            //myArrayList.Add("MyFirstItem");
            //myArrayList.Add(13.35);
            //myArrayList.Add(13);
            //myArrayList.Add(128);

            //// Delete elements with specific value from arrayList
            //myArrayList.Remove(13);

            //// Delete element at specific positions.
            //myArrayList.RemoveAt(0);

            //Console.WriteLine("There are {0} elements in myArrayList", myArrayList.Count);

            //double sum = 0;

            //foreach (object obj in myArrayList)
            //{
            //    // If object is an integer, convert it into a double
            //    if(obj is int)
            //    {
            //        sum += Convert.ToDouble(obj);       // Converting object to double
            //    } else if (obj is double)
            //    {
            //        sum += (double)obj;                 // Casting Object to Double
            //    } else if (obj is string)
            //    {
            //        Console.WriteLine(obj);             // Printing obj string value
            //    }
            //}

            //Console.WriteLine(sum);

            // =============================================
            // ================= Lists =====================
            // =============================================

            // For collections that have only one data type, must include System.Collections.Generic

            // List declaration Examples
            // var numbers = new List<int>();               // List of type int without values.
            // var numbers = new List<int>{1,5,35,100};     // List of type int with values.

            // Adding and removing values: 
            // var numbers = new List<int>();
            // numbers.Add(7);                              // Adds an integer with value of 7 to our list.
            // numbers.Remove(7);                           // Removes an element with a value of 7 from our list.

            // int index 0;
            // numbers.RemoveAt(index)                      // Removes an element at a specific position (index).


            // Getting a value
            // var numbers = new List<int>();
            // numbers.Add(7);                              // Adds an integer with value of 7 to our list.
            // int value = numbers[0]                       // Will be 25

            // Clearing a List 
            // var numbers = new List<int>();
            // numbers.Add(25);
            // numbers.Add(50);
            // numbers.Clear();                             // Deletes every element in our list

            // Lists and Loops
            // var numbers = new List<int>{5,10, 15,20,25,30,35,40};   

            //foreach (int element in numbers)              // foreach loop
            //{
            //    Console.WriteLine(element);
            //}

            //for (int i = 0; i < numbers.Count; i++)       // for loop
            //{
            //    Console.WriteLine(element);
            //}

            // =============================================
            // ============= Lists Challenge ===============
            // =============================================
            //// Write a method that returns a list of even integers between 100 and 170
            //// using this loop to print numbers instead of having to place them in the list.
            //for (int i = 100; i <= 170; i++)
            //{
            //    Console.Write(i+ ", ");
            //}

            //foreach (var num in Solution())
            //{
            //    Console.Write(num);
            //}

            // =============================================
            // ================ Hashtables =================
            // =============================================

            // Hashtables and dictionaries are the most useful collections in C#.
            // Now introducing Hashtables.

            // Key - Value (Pairs)
            // Auto - Car

            // Dictionaries and Hashtables are Key-Value pair collections. 
            // The difference is that Dictionaries have to be of the same type while
            // Hashtables can be of any type.

            // Creating Class Student.
            // Creating student objects
            //Student student1 = new Student(1, "John", 3.16f);
            //Student student2 = new Student(2, "Jim", 3.50f);
            //Student student3 = new Student(3, "Carly", 3.80f);
            //Student student4 = new Student(4, "Harry", 3.90f);

            //// Creating Hashtable
            //Hashtable studentsTable = new Hashtable();

            //// Adding students to student table
            //studentsTable.Add(student1.Id, student1);
            //studentsTable.Add(student2.Id, student2);
            //studentsTable.Add(student3.Id, student3);
            //studentsTable.Add(student4.Id, student4);

            //// Retrieve entries from hashtable. Retrieve individual item with known ID.
            //Student storedStudent = (Student)studentsTable[student1.Id];

            //Console.WriteLine("Stored Student ID: {0}, Name: {1}, GPA: {2}", storedStudent.Id, storedStudent.Name, storedStudent.GPA);

            //// Retrieve all items from a Hashtable.
            //foreach (DictionaryEntry entry in studentsTable)
            //{
            //    Student tempStudent = (Student)entry.Value;
            //    Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", tempStudent.Id, tempStudent.Name, tempStudent.GPA);
            //}
            //// A hashtable is a collection of dictionary entries

            //Console.WriteLine();
            //// Simplifying foreach
            //foreach (Student std in studentsTable.Values)
            //{
            //    Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", std.Id, std.Name, std.GPA);
            //}

            // =============================================
            // =========== Hashtables Challenge ============
            // =============================================


            // Write a program that will iterate through each element of the students array and insert them
            // Into a hashtable. If a student with the same ID exists in the hashtable, skip it and display the following: 
            // "Sorry, a student with the same ID already exists."
            // Hint: Use the method containsKey to check wether a student with the same ID already exists.

            //List<Student> studentList = new List<Student>();

            //Student student1 = new Student(1, "John", 3.16f);
            //Student student2 = new Student(2, "Jim", 3.50f);
            //Student student3 = new Student(3, "Carly", 3.80f);
            //Student student4 = new Student(4, "Harry", 3.90f);
            //Student student5 = new Student(5, "Timmy", 3.10f);
            //Student student6 = new Student(6, "Clay", 3.15f);
            //Student student7 = new Student(7, "Karen", 3.75f);
            //Student student8 = new Student(8, "Tommy", 3.65f);

            //studentList.Add(student1);
            //studentList.Add(student2);
            //studentList.Add(student3);
            //studentList.Add(student4);
            //studentList.Add(student5);
            //studentList.Add(student6);
            //studentList.Add(student7);
            //studentList.Add(student8);

            //// Creating Hashtable
            //Hashtable studentsTable = new Hashtable();

            //// Adding students to student table
            //studentsTable.Add(student1.Id, student1);
            //studentsTable.Add(student2.Id, student2);
            //studentsTable.Add(student3.Id, student3);
            //studentsTable.Add(student4.Id, student4);

            //foreach (Student student in studentList)
            //{
            //    if (studentsTable.ContainsKey(student.Id))
            //    {
            //        Console.WriteLine("Sorry, a student with ID {0} already exists", student.Id);
            //    } else
            //    {
            //        Console.WriteLine("Adding Student: {0},Student ID: {1}, GPA: {2} ", student.Name, student.Id, student.GPA);
            //        studentsTable.Add(student.Id, student);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Printing student table");
            //// Printing Student Hashtable
            //foreach (Student student in studentsTable.Values)
            //{
            //    Console.WriteLine("Showing Student: {0}, Student ID: {1}, GPA: {2} ", student.Name, student.Id, student.GPA);
            //}

            // =============================================
            // =============== Dictionaries ================
            // =============================================

            // A dictionary is a generic version of a Hashtable.
            // A dictionary is a collection of key value pairs.

            // Key- Value Pairs
            // Declaring a Dictionary. (A Dictionary is a generic collection.
            //Dictionary<int, string> myDictionary = new Dictionary<int, string>() { { 1, "one" }, { 2, "two" }, { 3, "three" } };

            //// Alternative way to declare dictionaries: 
            //Dictionary<int, string> myDictionary2 = new Dictionary<int, string>();

            //// Creating class employee
            //// Creating Employees list (Database)
            //Employee[] employees = { 
            //    new Employee("Developer", "John", 20, 40),
            //    new Employee("HR", "Jannet", 35, 25),
            //    new Employee("CEO", "Louis", 80, 200),
            //    new Employee("Secretary", "Sebastian", 30, 40),
            //    new Employee("Lead", "Arto", 25, 60),
            //    new Employee("Intern", "Ernest", 21, 35),
            //};

            //// Creating employees Directory Dictionary
            //Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            //foreach (Employee emp in employees)
            //{
            //    employeesDirectory.Add(emp.Role, emp);
            //}

            //// To avoid exceptions, check if the key exists in the dictionary before retrieving it: 
            //if (employeesDirectory.ContainsKey("CEO"))
            //{
            //    Employee empl = employeesDirectory["CEO"];

            //    Console.WriteLine("Employee Name: {0}\nRole: {1}\nSalary: {2}", empl.Name, empl.Role, empl.Salary);
            //} else
            //{
            //    Console.WriteLine("This key does not exists.");
            //}
            //Console.WriteLine();
            //// Another way of avoiding errors while accessing dictionaries is using the TryGetValue method.
            //Employee result = null;
            //if (employeesDirectory.TryGetValue("Intern", out result))
            //{
            //    Console.WriteLine("Employee Name: {0}\nRole: {1}\nSalary: {2}", result.Name, result.Role, result.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("This key does not exists.");
            //}

            //// Updating a value in the Dictionary
            //string keyToUpdate = "HR";
            //if (employeesDirectory.ContainsKey(keyToUpdate))
            //{
            //    employeesDirectory[keyToUpdate] = new Employee("HR", "Teresa", 26, 18.24f);
            //    Console.WriteLine("Updating Employee with Role/Key \"{0}\"", keyToUpdate);
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("No Employee found with Role/Key \"{0}\"", keyToUpdate);
            //    Console.WriteLine();
            //}


            //// Removing values from dictionary
            //string KeyToRemove = "Intern";
            //if (employeesDirectory.Remove(KeyToRemove))
            //{
            //    Console.WriteLine("The Employee with Role/Key \"{0}\" was removed.", KeyToRemove);
            //    Console.WriteLine();
            //} else
            //{
            //    Console.WriteLine("No Employee found with Role/Key \"{0}\"", keyToUpdate);
            //    Console.WriteLine();
            //}

            //// Getting element with the ElementAt method. (Using the key as an integer)
            //for (int i = 0; i < employeesDirectory.Count; i++)
            //{
            //    // Using ElementAt(i) to return the key-value pair stored at index i.
            //    KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
            //    // Print the key
            //    Console.WriteLine("Key: {0}", keyValuePair.Key);
            //    // Storing employee value in an employee object.
            //    Employee employeeObj = keyValuePair.Value;
            //    // Printing the properties of the employee object.
            //    Console.WriteLine("Employee Name: {0}\nRole: {1}\nAge: {2}\nSalary: {3}", employeeObj.Name, employeeObj.Role, employeeObj.Age, employeeObj.Salary);
            //    Console.WriteLine();
            //}

            // =============================================
            // = Editing and Removing Data in Dictionaries =
            // =============================================

            // Using the EmployeeDirectory Dictionary defined above. (Starting at line 800 in order to reuse code.) 

            // =============================================
            // ======== Queues and Stacks Overview =========
            // =============================================

            // ==========
            // = Stacks =
            // ==========

            // Data can be added and removed from the top.
            // Can't access the elements in the middle.
            // First In, Last Out (LIFO)

            // Stack uses

            // Reversing Data
            // Web browser back button
            // Undo/Redo Buttons

            // Stack Operations:

            // Push(Object obj). Add data to the top of the stack.
            // Pop(). Remove data from the top of the stack.
            // Peek(). View data on top of the stack.


            // ==========
            // = Queues =
            // ==========

            // Data can be added from the rear and removed from the front.
            // Can't access the elements in the middle.
            // First In, First Out (FIFO)

            // Queue uses

            // OS IO requests, mouse movements.
            // Managing web requests in a server.
            // Queuing input in video games.

            // Queue operations

            // Enqueue(Object obj). Add data to the back of the queue.
            // Dequeue(). Remove data from the front of the queue.
            // Peek(). return data in the front of the queue.


            // =============================================
            // =================== Stacks ==================
            // =============================================


            //// Defining stack. (Stacks are generic collections)
            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //Console.WriteLine("Top value in stack is {0}", stack.Peek());
            //stack.Push(20);
            //Console.WriteLine("Top value in stack is {0}", stack.Peek());
            //stack.Push(30);
            //Console.WriteLine("Top value in stack is {0}", stack.Peek());
            //stack.Push(40);
            //Console.WriteLine("Top value in stack is {0}", stack.Peek());
            //stack.Push(50);
            //Console.WriteLine("Top value in stack is {0}", stack.Peek());

            //// Remove items from the stack
            //// Check if stack has an item before popping
            //while(stack.Count > 0)
            //{
            //    Console.WriteLine("Popped {0} from the top of the stack.", stack.Pop());
            //    Console.WriteLine("Current stack count: {0}", stack.Count);
            //    if(stack.Count == 0)
            //        Console.WriteLine("Stack is empty");
            //    else
            //        Console.WriteLine("Top value in stack is {0}", stack.Peek());
            //}


            //// Reversing an Array.
            //int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            //// Defining a new stack of int
            //Stack<int> myStack = new Stack<int>();
            //Console.WriteLine();
            //Console.WriteLine("The numbers in the array are: ");

            //// Foreach number in our array
            //foreach (int number in numbers)
            //{
            //    // Print number
            //    Console.Write(number + " ");
            //    myStack.Push(number);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Numbers in reverse: ");
            //// As long as our stack is not empty.
            //while (myStack.Count > 0)
            //{
            //    Console.Write(myStack.Pop() + " ");
            //}
            //Console.WriteLine();


            // =============================================
            // =================== Queues ==================
            // =============================================

            // Queues should be used when the order of the data is important.
            // FIFO (First in, First Out)

            //Queue<int> queue = new Queue<int>();

            //// Adding items to a queue
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //// Printing the element at the front of the queue. First item in queue.
            //Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());

            //// Removing first item from the queue
            //// First check if there are items to remove before attempting to remove them.
            //while(queue.Count > 0)
            //{
            //    Console.WriteLine("Removing first item from the queue: {0}", queue.Dequeue());
            //    Console.WriteLine("Queue Count: {0}", queue.Count);
            //    if(queue.Count != 0)
            //    {
            //        Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            //    } else
            //    {
            //        Console.WriteLine("The queue is empty");
            //    }
            //}

            // Real world example
            // Creating Order class
            Queue<Order> ordersQueue = new Queue<Order>();

            // Receiving Orders from branch 1
            foreach (Order o in ReceivingOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            // Receiving Orders from branch 2
            foreach (Order o in ReceivingOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            // Process orders
            while (ordersQueue.Count > 0)
            {
                ordersQueue.Dequeue().ProcessOrder();
            }
            Console.WriteLine("All orders processed!");

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

        /// <summary>
        /// This function gets the average grade from a double[] array
        /// </summary>
        /// <param name="gradesArray"></param>
        /// <returns></returns>
        static double GetAverage(double[] gradesArray)
        {
            int size = gradesArray.Length;
            double sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            return sum / size;
        }

        /// <summary>
        /// This method takes in an integer array and increases its values by 2.
        /// </summary>
        /// <param name="happiness"></param>
        static void increaseByTwo(int[] happiness)
        {
            for (int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }

        /// <summary>
        /// Method used to explain the params keyword.
        /// </summary>
        /// <param name="sentence"></param>
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i]+ " ");
            }
        }

        /// <summary>
        /// This method is used to explain params using objects
        /// </summary>
        /// <param name="sentence"></param>
        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj.ToString() + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This function returns the smallest number in a list of numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int MinValue(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        /// <summary>
        /// Method is a coding exercise for lists. Method returns even numbers
        /// from list containing numbers from 100 to 170
        /// </summary>
        /// <returns></returns>
        public static List<int> Solution()
        {
            // TODO: write your solution here
            var numbers = new List<int> { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170 };
            var evenNums = new List<int>();
            for (int i = 0; i < numbers.Count; i++){
                if (numbers[i] % 2 == 0)
                {
                    evenNums.Add(numbers[i]);
                }
            }
            return evenNums;
        }

        /// <summary>
        /// Function used for real world queue example.
        /// </summary>
        /// <returns></returns>
        static Order[] ReceivingOrdersFromBranch1()
        {
            // Creating new orders array
            Order[] orders = new Order[]
            {
                    new Order(1,5),
                    new Order(2,4),
                    new Order(6,10)
            };
            return orders;
        }

        /// <summary>
        /// Function used for real world queue example.
        /// </summary>
        /// <returns></returns>
        static Order[] ReceivingOrdersFromBranch2()
        {
            // Creating new orders array
            Order[] orders = new Order[]
            {
                    new Order(3,5),
                    new Order(4,4),
                    new Order(5,10)
            };
            return orders;
        }
    }

    
}
