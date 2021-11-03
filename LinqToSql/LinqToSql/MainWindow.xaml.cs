using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqToSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            // ====================================
            //   Setting up Project for LinqToSQL
            // ====================================
            InitializeComponent();
            // Setting up connection String
            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.CSharpTutorialsDBConnectionString"].ConnectionString;

            // Adding new Class LinqToSQL

            // Assigning data context
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            // ====================================
            // Inserting Objects into Our Database
            // ====================================

            // Calling Insert Universities Method
            //InsertUniversities();
            // Challenge: Add Another university and run the app. (Added Umet and Georgetown)

            // Calling Insert Student Method.
            //InsertStudent();

            // ====================================
            //  Using Associative Tables with Linq
            // ====================================

            // Inserting Lectures
            //InsertLectures();

            //InsertStudentLectureAssociations();

            ////Getting Tony's university.
            //GetUniversityOfTony();

            //// Challenge, Get Tony's Lectures (Use a query)
            //GetTonysLectures();

            // ====================================
            //       Joining Tables Next Level
            // ====================================

            //// Getting all students from a specific university.
            //GetAllStudentsFromYale();
            //GetAllStudentsFromUmet();
            //GetAllStudentsFromGeorgetown();

            //// Getting all universities with transgender students.
            //GetAllUniversitiesWithTransgenders();

            //// Get all lectures taught at Yale
            //GetAllLecturesTaughtAtYale();

            // ====================================
            //         Deleting and Updating
            // ====================================

            //// Updating Data.
            //// Updating student Tony
            //UpdateTony();

            //// Jamie graduated. Deleting Jamie.
            //DeleteJamie();

        }
        /// <summary>
        /// Inserts University data into our University Table in the Database
        /// </summary>
        public void InsertUniversities()
        {
            // To create a univiersity object, go to the LinqToSqlDataClasses file,
            // Open server explorer, click on the University table and drag it into
            // the LinqToSqlDataClasses file.
            University yale = new University();
            yale.Name = "Yale";

            University Umet = new University();
            Umet.Name = "Universidad Metropolitana";

            University Georgetown = new University();
            Georgetown.Name = "Georgetown";

            // To insert university into the data table, 
            dataContext.Universities.InsertOnSubmit(yale);
            dataContext.Universities.InsertOnSubmit(Umet);
            dataContext.Universities.InsertOnSubmit(Georgetown);

            // Submiting changes in data context.
            dataContext.SubmitChanges();

            // Showing data in data grid
            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        /// <summary>
        /// Inserts Student data into our Student Table in the Database
        /// </summary>
        public void InsertStudent()
        {
            // First returns the first instance that matches the search. (Using lambda expression to search for Yale)
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            // Is the same as typing: from university in dataContext.University where university.Name == "Yale" select university;
            
            University Umet = dataContext.Universities.First(un => un.Name.Equals("Universidad Metropolitana"));

            University Georgetown = dataContext.Universities.First(un => un.Name.Equals("Georgetown"));

            // Adding a list of students.
            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "Female", UniversityId = Umet.Id });
            // Instead of using university ID, i can use the university itself
            students.Add(new Student { Name = "Tony", Gender = "Male", University = yale });

            students.Add(new Student { Name = "Layla", Gender = "Female", University = Georgetown });

            students.Add(new Student { Name = "Jamie", Gender = "Transgender", University = yale });

            // Inserting all students
            dataContext.Students.InsertAllOnSubmit(students);

            // Submiting changes in data context.
            dataContext.SubmitChanges();

            // Showing data in data grid
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        /// <summary>
        /// Inserts Lecture Data into our Lecture Table in the Database.
        /// </summary>
        public void InsertLectures()
        {
            // Adding lectures to our LinqToSqlDataClasses
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Physics" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Computer Science" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;

        }

        /// <summary>
        /// Inserts student relations to lectures in StudentLecture table in Database.
        /// </summary>
        public void InsertStudentLectureAssociations()
        {
            // Getting students
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Tony = dataContext.Students.First(st => st.Name.Equals("Tony"));
            Student Layla = dataContext.Students.First(st => st.Name.Equals("Layla"));
            Student Jamie = dataContext.Students.First(st => st.Name.Equals("Jamie"));

            // Getting lectures
            Lecture Math = dataContext.Lectures.First(lec => lec.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lec => lec.Name.Equals("History"));
            Lecture Physics = dataContext.Lectures.First(lec => lec.Name.Equals("Physics"));
            Lecture ComputerScience = dataContext.Lectures.First(lec => lec.Name.Equals("Computer Science"));

            // Adding student lecture relation.
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Physics });

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tony, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tony, Lecture = History });

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Layla, Lecture = History });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Layla, Lecture = ComputerScience });

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jamie, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jamie, Lecture = Physics });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jamie, Lecture = History });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jamie, Lecture = ComputerScience });

            // Submiting changes in data context.
            dataContext.SubmitChanges();

            // Showing data in data grid
            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        /// <summary>
        /// Returns university of Student named Tony.
        /// </summary>
        public void GetUniversityOfTony()
        {
            Student Tony = dataContext.Students.First(st => st.Name.Equals("Tony"));

            University tonysUniversity = Tony.University;

            List<University> universities = new List<University>();

            universities.Add(tonysUniversity);

            // Can't just add object "tonysUniversity" because the
            // ItemsSource method expects an IEnumerable type.
            MainDataGrid.ItemsSource = universities;
        }

        /// <summary>
        /// Returns all of tony's lectures
        /// </summary>
        public void GetTonysLectures()
        {
            Student Tony = dataContext.Students.First(st => st.Name.Equals("Tony"));
            var tonysLectures = from student in Tony.StudentLectures select student.Lecture;


            MainDataGrid.ItemsSource = tonysLectures;
        }

        /// <summary>
        /// Shows all students from Yale in the data grid
        /// </summary>
        public void GetAllStudentsFromYale()
        {
            //var studentsFromYale = from student in dataContext.Students
            //                       join university in dataContext.Universities on student.UniversityId equals university.Id
            //                       where university.Name == "Yale"
            //                       select student;

            // Using an easier way
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        /// <summary>
        /// Shows all students from Umet in the data grid
        /// </summary>
        public void GetAllStudentsFromUmet()
        {
            //var studentsFromYale = from student in dataContext.Students
            //                       join university in dataContext.Universities on student.UniversityId equals university.Id
            //                       where university.Name == "Yale"
            //                       select student;

            // Using an easier way
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Universidad Metropolitana"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        /// <summary>
        /// Shows all students from Georgetown in the data grid
        /// </summary>
        public void GetAllStudentsFromGeorgetown()
        {
            //var studentsFromYale = from student in dataContext.Students
            //                       join university in dataContext.Universities on student.UniversityId equals university.Id
            //                       where university.Name == "Yale"
            //                       select student;

            // Using an easier way
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Georgetown"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        /// <summary>
        /// Shows all universies that have transgender students in the data grid
        /// </summary>
        public void GetAllUniversitiesWithTransgenders()
        {
            var transUnis = from student in dataContext.Students
                            join university in dataContext.Universities on student.UniversityId equals university.Id
                            where student.Gender == "Transgender"
                            select university;

            MainDataGrid.ItemsSource = transUnis;
        }

        /// <summary>
        /// Shows all lectures taught at Yale.
        /// </summary>
        public void GetAllLecturesTaughtAtYale()
        {
            var lecturesAtYale = from studLects in dataContext.StudentLectures
                                 join student in dataContext.Students on studLects.StudentId equals student.Id
                                 where student.University.Name == "Yale"
                                 select studLects.Lecture;

            MainDataGrid.ItemsSource = lecturesAtYale;
        }

        /// <summary>
        /// This method changes Tony's name to Antonio.
        /// </summary>
        public void UpdateTony()
        {
            Student Tony = dataContext.Students.FirstOrDefault(st => st.Name == "Tony");

            // Changing Tony's name to Antonio.
            Tony.Name = "Antonio";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        /// <summary>
        /// Jamie graduated from university. Deleting student Jamie.
        /// </summary>
        public void DeleteJamie()
        {
            Student Jamie = dataContext.Students.FirstOrDefault(st => st.Name == "Jamie");

            // Deleting
            dataContext.Students.DeleteOnSubmit(Jamie);

            // Submitting changes to data context.
            dataContext.SubmitChanges();
            // Show students in main data grid
            MainDataGrid.ItemsSource = dataContext.Students;
        }

    }

}
