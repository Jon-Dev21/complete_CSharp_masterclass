using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Linq_With_Lists
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }


        // Foreign key (If person is not in a university, person is not a student.)
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student Name: {0}\nStudent Id: {1}\nGender: {2}\nAge: {3}\nUniversity Id: {4}", Name,Id,Gender,Age,UniversityId);
        }
    }
}
