using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    /// <summary>
    /// Cat Class used to explain IEnumerator and IEnumerable.
    /// This class was supposed to be a dog class but I created one earlier when explaining the basics of inheritance.
    /// </summary>
    class Cat
    {
        public string Name { get; set; }
        public bool IsNaughtyCat { get; set; }

        public Cat(string name, bool isNaughtyCat)
        {
            Name = name;
            IsNaughtyCat = isNaughtyCat;
        }

        /// <summary>
        /// This method prints how many treats the cat received.
        /// </summary>
        /// <param name="numberOfTreats"></param>
        public void GiveTreat(int numberOfTreats)
        {
            if(!IsNaughtyCat)
                Console.WriteLine("{0} the Cat is behaving well. Giving {1} treats.", Name, numberOfTreats);
            else
                Console.WriteLine("{0} the Cat is being naughty. Giving only {1} treats.", Name, numberOfTreats>=1? numberOfTreats - 1 : 1);
        }
    }
}
