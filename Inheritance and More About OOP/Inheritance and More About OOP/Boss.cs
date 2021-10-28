using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    /// <summary>
    /// Boss class. Inherits from employee.
    /// (Inheritance challenge 2 class)
    /// </summary>
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss() {}

        public Boss(string firstName, string surname, int salary, string companyCar)
        {
            FirstName = firstName;
            Surname = surname;
            Salary = salary;
            CompanyCar = companyCar;
        }

        /// <summary>
        /// Prints out the boss's info
        /// </summary>
        public void Lead()
        {
            Console.WriteLine("I'm leading. Check out my info\n\nBoss Name: {0}, \nSurname: {1}, \nSalary: {2}, \nCompany Car Brand: {3}", FirstName,Surname,Salary,CompanyCar);
        }
    }
}
