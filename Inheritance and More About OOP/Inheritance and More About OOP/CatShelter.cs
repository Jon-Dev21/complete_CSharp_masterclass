using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_More_About_OOP
{
    // Class Cat Shelter.
    // This class contains a generic collection of type Cat.
    // Objects of this class can't be used inside a foreach loop because
    // the IEnumerable interface has not been implemented 
    class CatShelter : IEnumerable<Cat>
    {
        // List of Type List<Cat>
        public List<Cat> cats;

        public CatShelter()
        {
            // Initialize the cats list using the collection-initalizer.
            cats = new List<Cat>()
            {
                new("Tom", false),
                new("Puss", true),
                new("Big", false),
                new("Larry", true),
                new("Peeves", false),
            };
        }
        // Right Clicked on IEnumerable<Cat> error and clicked on implement all members Explicitly.

        IEnumerator<Cat> IEnumerable<Cat>.GetEnumerator()
        {
            // Return the individual cats.
            return cats.GetEnumerator();
        }

        // Not implementing this one because we don't use a non generic example and Cat Shelter is generic.
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
