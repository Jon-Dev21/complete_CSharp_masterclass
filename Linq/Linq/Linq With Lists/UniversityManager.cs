using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Linq_With_Lists
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Adding Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });


            // Adding Students
            students.Add(new Student { Id=1, Name= "John", Gender="Male", Age = 17, UniversityId = 1});
            students.Add(new Student { Id = 2, Name = "Martha", Gender = "Male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Kayla", Gender = "Female", Age = 19, UniversityId = 1 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "Transgender", Age = 29, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Mark", Gender = "Male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Becky", Gender = "Female", Age = 17, UniversityId = 2 });
        }

        // Will give us all the male students.
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudent = from student in students where student.Gender == "Male" select student;
            foreach (Student student in maleStudent)
            {
                student.Print();
                Console.WriteLine();
            }
        }

        // Will give us all the female students
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudent = from student in students where student.Gender == "Female" select student;
            foreach (Student student in femaleStudent)
            {
                student.Print();
                Console.WriteLine();
            }
        }

        // Will give us all the transgender students
        public void TransgenderStudents()
        {
            IEnumerable<Student> transgenderStudent = from student in students where student.Gender == "Transgender" select student;
            foreach (Student student in transgenderStudent)
            {
                student.Print();
                Console.WriteLine();
            }
        }
    }
}
