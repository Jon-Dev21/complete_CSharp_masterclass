using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    /// <summary>
    /// Trainee class. Inherits from employee.
    /// (Inheritance challenge 2 class)
    /// </summary>
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string firstName, string surname, int salary, int workingHours, int schoolHours)
        {
            FirstName = firstName;
            Surname = surname;
            Salary = salary;
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("In my {0} School Hours, I am learning.", SchoolHours);
        }

        public override void Work()
        {
            Console.WriteLine("{0} {1}'s Working hours: {2}", FirstName, Surname, WorkingHours);
        }
    }
}
