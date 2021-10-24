using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Members
    {
        // member - private fields
        private string memberName;
        private string jobTitle;
        private int salary;
        // member - public fields
        public int age;

        // member - property - exposes jobTitle safely - properties start with capital letters.
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // Can also use shorthand properties (type prop & press tab twice).
        // Example: 
        // public string JobTitle { get; set; }

        // public member method - can be called from other classes.
        public void Introducing(bool isFriend)
        {
            if(isFriend)
                SharingPrivateInfo();
            else
                Console.WriteLine("Hi, my name is {0}. My job title is {1}. I am {2} years old.", memberName, jobTitle, age);
        } 

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor (classes can have multiple constructors but one destructor)
        // Destructors are used to deallocate unused resources. Used to improve performance.
        // Destructors are invoked when the object is out of the scope of where it's invoked.
        ~Members()
        {
            // cleanup statements.
            Console.WriteLine("Deconstruction of Members Object"); // This statement is barely visible.
            // Importing System.Diagnostics and using debug class to see destructor in action.
            Debug.Write("Deconstruction of Members Object");
        }
    }
}
