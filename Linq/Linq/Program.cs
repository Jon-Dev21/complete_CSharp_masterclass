using Linq.Linq_With_Lists;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //int[] numbers = {1,2,3,4,5,6,7,8,9 };
            //// This method uses Linq to assign odd numbers to an IEnumerable List of integers and print it.
            //OddNumbers(numbers);

            // ============================================
            // ============= Linq With Lists ==============
            // ============================================

            // Creating new class "University"
            // Creating new class "Student"
            // Creating new class "UniversityManager"

            UniversityManager universityManager = new UniversityManager();
            Console.WriteLine("=================== Male Students ===================");
            universityManager.MaleStudents();
            Console.WriteLine("=================== Female Students ===================");
            universityManager.FemaleStudents();
            Console.WriteLine("=================== Transgender Students ===================");
            universityManager.TransgenderStudents();
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
