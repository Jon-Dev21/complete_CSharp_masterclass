using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    /// <summary>
    /// Every instance of this class represents a Human.
    /// </summary>
    class Human
    {
        // ==================================================
        // ============= Creating a Class ===================
        // ==================================================

        // Member Variables
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // ==================================================
        // ============= Using Constructors =================
        // ==================================================

        // Default Constructor
        /// <summary>
        /// Default constructor for human class.
        /// </summary>
        public Human()
        {
            Console.WriteLine("Constructor Called. Object Created.");
        }

        //  Parameterized Constructor
        /// <summary>
        /// Pass in two strings. First name and last name.
        /// </summary>
        /// <param name="firstName"></param>
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        //  Parameterized Constructor
        /// <summary>
        /// Pass in two strings. First name and last name.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //  Parameterized Constructor
        /// <summary>
        /// Pass in three strings. First name, last name, eye color.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="eyeColor"></param>
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        //  Parameterized Constructor
        /// <summary>
        /// Pass in three strings. First name, last name, eye color. Pass in the age as an integer.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="eyeColor"></param>
        /// <param name="age"></param>
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // Memeber method
        public void IntroduceMyself()
        {
            if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(eyeColor) && age == 0)
            {
                Console.WriteLine("Hello, My name is {0}.", firstName);
            } else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(eyeColor) && age == 0)
            {
                Console.WriteLine("Hello, My full name is {0} {1}.", firstName, lastName);
            } else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(eyeColor) && age == 0)
            {
                Console.WriteLine("Hello, My name is {0} {1}. I have {2} eyes.", firstName, lastName, eyeColor);
            } else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(eyeColor) && age != 0)
            {
                Console.WriteLine("Hello, My name is {0} {1}. I am {2} years old and I have {3} eyes.", firstName, lastName, age, eyeColor);
            }

        }

        // Memeber method
        public void HowOldAmI()
        {
            
            Console.WriteLine(age == 1 ? "I am "+age+" year old." : "I am " + age + " years old.");
        }

        // Memeber method
        public void WhatIsMyEyeColor()
        {
            Console.WriteLine("I have {0} eyes", eyeColor);
        }

        // Memeber method
        public void AboutMyself()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Eye Color: {0}", eyeColor);
        }
    }
}
