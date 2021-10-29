using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates.Creating_Your_Own_Delegates
{
    class Person
    {
        // Name
        public string Name { get; set; }
        // Age property
        public int Age { get; set; }

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }
    }
}
