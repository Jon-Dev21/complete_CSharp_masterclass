using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_In_CSharp
{
    class Student
    {
        // Property called id
        public int Id { get; set; }

        // Property called Name
        public string Name { get; set; }

        // Property called GPA
        public float GPA { get; set; }

        // Simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
