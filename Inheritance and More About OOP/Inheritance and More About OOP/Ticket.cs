using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    // Implementing Interface IEquatable. This method requires us to implement an Equals method.
    // Class for Interfaces Section of course
    class Ticket : IEquatable<Ticket>
    {
        // Property to store the duration of the ticket in hours.
        public int DurationInHours { get; set; }

        // Simple constructor
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        /// <summary>
        /// Compares duration in hours from passed ticket to this ticket.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
