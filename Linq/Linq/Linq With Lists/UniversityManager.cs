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

        /// <summary>
        /// Will give us all the male students.
        /// </summary>
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudent = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("=================== Male Students ===================");
            foreach (Student student in maleStudent)
            {
                student.Print();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Will give us all the female students
        /// </summary>
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudent = from student in students where student.Gender == "Female" select student;
            Console.WriteLine("=================== Female Students ===================");
            foreach (Student student in femaleStudent)
            {
                student.Print();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Will give us all the transgender students
        /// </summary>
        public void TransgenderStudents()
        {
            IEnumerable<Student> transgenderStudent = from student in students where student.Gender == "Transgender" select student;
            Console.WriteLine("=================== Transgender Students ===================");
            foreach (Student student in transgenderStudent)
            {
                student.Print();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Create a list of students sorted by age.
        /// </summary>
        public void SortStudentByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("=================== Students by Age ===================");
            foreach (Student student in sortedStudents)
            {
                student.Print();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints a list of all students that attend Beijing Tech
        /// </summary>
        public void AllStudentsFromBeijingTech()
        {
            // List of all students from Beijing Tech
            IEnumerable<Student> beijingTechStudents = from student in students
                                                       join university in universities on student.UniversityId equals university.Id
                                                       where university.Name == "Beijing Tech"
                                                       select student;
            Console.WriteLine("=================== Students From Beijing Tech ===================");
            foreach (Student student in beijingTechStudents)
            {
                student.Print();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints a list of all students that attend Beijing Tech
        /// </summary>
        public void AllStudentsFromYale()
        {
            // List of all students from Beijing Tech
            IEnumerable<Student> yaleStudents = from student in students
                                                       join university in universities on student.UniversityId equals university.Id
                                                       where university.Name == "Yale"
                                                       select student;
            Console.WriteLine("=================== Students From Yale ===================");
            foreach (Student student in yaleStudents)
            {
                student.Print();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Returns students from the specific university Id passed.
        /// </summary>
        /// <param name="id"></param>
        public void AllStudentsFromSpecifiedUniversityId(int id)
        {
            IEnumerable<Student> studentsFromSpecificUni = from student in students
                                                           join university in universities on student.UniversityId equals university.Id
                                                           where university.Id == id
                                                           select student;

            
            if (id == 1 || id == 2)
            {
                Console.WriteLine("=================== Students From {0} ===================", id == 1 ? "Yale": "Beijing Tech");
                foreach (Student student in studentsFromSpecificUni)
                {
                    student.Print();
                    Console.WriteLine();
                }
            } else
            {
                Console.WriteLine("University not found...");
            }
            

        }

        /// <summary>
        /// Prints a collection of all students and their universities.
        /// </summary>
        public void StudentAndUniversityNameCollection()
        {
            // We fetch all students and their university, 
            // order them by their name and put their names
            // in a new object together with the university name
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("Students and their universities: \n");
            foreach (var collection in newCollection)
            {
                Console.WriteLine("Student: {0}\nUniversity: {1}\n", collection.StudentName, collection.UniversityName);
            }
        }

    }
}
