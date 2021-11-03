using Linq.Linq_With_Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============================================
            // ================ LINQ DEMO =================
            // ============================================

            // Created array of numbers.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // This method uses Linq to assign odd numbers to an IEnumerable List of integers and print it.
            OddNumbers(numbers);

            // ============================================
            // ============= Linq With Lists ==============
            // ============================================

            // Creating new class "University"
            // Creating new class "Student"
            // Creating new class "UniversityManager"

            UniversityManager universityManager = new UniversityManager();

            universityManager.MaleStudents();

            universityManager.FemaleStudents();

            universityManager.TransgenderStudents();

            // ============================================
            // ====== Sorting & filtering with Linq =======
            // ============================================

            universityManager.SortStudentByAge();

            universityManager.AllStudentsFromBeijingTech();

            universityManager.AllStudentsFromYale();

            Console.Write("Enter university Id: ");
            string id = Console.ReadLine();
            int numId = Convert.ToInt32(id);
            universityManager.AllStudentsFromSpecifiedUniversityId(numId);


            // How to reverse sorted data.
            int[] someInts = { 12, 453, 6236, 2345, 1, 237, 245, 1, 345, 134, 6, 45, 72, 4 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            Console.Write("Sorted ints: ");

            foreach (int num in sortedInts)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Console.Write("Reverse Sorted ints: ");

            foreach (int num in reversedInts)
            {
                Console.Write(num + ", ");
            }

            // Alternate way to reverse an array of integers.
            IEnumerable<int> otherSortedInts = from i in someInts orderby i descending select i;

            Console.Write("\n\nAlternate way to reverse array of integers\nReverse Sorted ints: ");

            foreach (int num in reversedInts)
            {
                Console.Write(num + ", ");
            }

            // ============================================
            // ====== Creating collections based ==========
            // ======    on other Collections    ==========
            // ============================================

            universityManager.StudentAndUniversityNameCollection();

            // ============================================
            // =============== Linq and XML ===============
            // ============================================

            string studentsXML = @"<Students>
                                     <Student>
                                         <Name>Toni</Name>
                                         <Age>21</Age>
                                         <University>Yale</University>
                                         <Semester>1</Semester>
                                     </Student>
                                     <Student>
                                         <Name>Carla</Name>
                                         <Age>17</Age>
                                         <University>Yale</University>
                                         <Semester>2</Semester>
                                     </Student>
                                     <Student>
                                         <Name>Leyla</Name>
                                         <Age>19</Age>
                                         <University>Beijing Tech</University>
                                         <Semester>3</Semester>
                                     </Student>
                                     <Student>
                                         <Name>Kenan</Name>
                                         <Age>23</Age>
                                         <University>Beijing Tech</University>
                                         <Semester>4</Semester>
                                     </Student>
                                   </Students>";

            // using System.Xml.Linq;
            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };
            Console.WriteLine("Printing students from XML: \n");
            foreach (var student in students)
            {
                Console.WriteLine("Student: {0}\nAge: {1}\nUniversity: {2}\nSemester: {3}\n", student.Name, student.Age, student.University, student.Semester);
            }

            // Challenge, sort students by their age
            var studentsByAge = from student in students
                                orderby student.Age
                                select student;
            Console.WriteLine("\nPrinting students from XML Ordered by age: \n");
            foreach (var student in studentsByAge)
            {
                Console.WriteLine("Student: {0}\nAge: {1}\nUniversity: {2}\nSemester: {3}\n", student.Name, student.Age, student.University, student.Semester);
            }

            // Challenge: Add another type of information and another student in the XML.
            // Added <Semester> tag to students


            // ============================================
            // ==== Setting up Project for LinqToSQL  =====
            // ============================================
            // Will be creating new WPF Project, LinqToSQL.
        }

        /// <summary>
        /// This method uses Linq to return odd numbers
        /// </summary>
        /// <param name="numbers"></param>
        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd numbers");

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
