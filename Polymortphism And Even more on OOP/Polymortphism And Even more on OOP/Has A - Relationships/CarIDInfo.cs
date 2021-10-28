using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymortphism_And_Even_more_on_OOP.Has_A___Relationships
{
    // Has A.
    class CarIDInfo
    {
        // Unique Number Identifier
        public int IDNum { get; set; } = 0;

        // Every car has an owner.
        public string Owner { get; set; } = "No Owner";
    }
}
