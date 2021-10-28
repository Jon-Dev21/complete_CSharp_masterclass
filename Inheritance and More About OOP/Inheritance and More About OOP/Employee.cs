using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    /// <summary>
    ///  Base class. Represents an employee. 
    ///  (Inheritance challenge 2 class)
    /// </summary>
    class Employee
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }

        public Employee() { }

        public Employee(string firstName, string surname, int salary)
        {
            FirstName = firstName;
            Surname = surname;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("{0} {1} is working.", FirstName, Surname);
        }

        public void Pause()
        {
            Console.WriteLine("{0} {1} is taking a break.", FirstName, Surname);
        }
    }
}
