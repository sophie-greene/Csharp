using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace edx5
{
    class Program
    {

        static void Main(string[] args) {
            Random r = new Random();

            Student Student1 = new Student("Paul", "M");

            for (int i = 0; i < 5; i++) {
                Student1.Grades.Push(r.Next(60, 100));
            }

            Student Student2 = new Student("John", "L");
            for (int i = 0; i < 5; i++) {
                Student1.Grades.Push(r.Next(60, 100));
            }
            Student Student3 = new Student("George", "H");
            for (int i = 0; i < 5; i++) {
                Student1.Grades.Push(r.Next(60, 100));
            }

            Course Course = new Course("Programming with C#");
            Course.Students.Add(Student1);
            Course.Students.Add(Student2);
            Course.Students.Add(Student3);


            Teacher Teacher = new Teacher("Ringo", "S");

            Course.Teachers.Add(Teacher);

            Degree Degree = new Degree("Bachelor of Science");

            Degree.Course = Course;

            Degree.Course = Course;
            UProgram UProgram = new UProgram("Information Technology");
            UProgram.Degree = Degree;

            //Console.WriteLine("{0} program contains {1} degree", UProgram.UProgramName, UProgram.Degree.DegreeName);
            //Console.WriteLine("{0} degree contains {1} course", Degree.DegreeName, Degree.Course.CourseName);
            //Console.WriteLine("{0} course contains {1} students", Course.CourseName, Course.Students.Count);

            Course.ListStudents();
            Console.ReadLine();

        }
    }
    public class Person
    {
        private string _firstName;
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Person(string firstname, string lastname) {
            _firstName = firstname;
            _lastName = lastname;
        }

    }

    public class Student : Person
    {
        public Stack<int> Grades;
        public DateTime birthDate { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }

        public Student(string firstname, string lastname) : base(firstname, lastname) {
            Grades = new Stack<int>();
        }

        public void TakeTest() {
            Console.WriteLine("{0} {1} is taking test", this.FirstName, this.LastName);
        }
    }

    public class Teacher : Person
    {

        public DateTime birthDate { get; set; }

        public Teacher(string firstname, string lastname) : base(firstname, lastname) {

        }

        public void GradeTest() {
            Console.WriteLine("{0} {1} is grading test", this.FirstName, this.LastName);
        }
    }

    public class Course
    {
        private string _courseName { get; set; }
        public string CourseName {
            get { return _courseName; }
            set { _courseName = value; }

        }

        #region other_data

        public string credits { get; set; }
        public string duration { get; set; }

        #endregion

        public ArrayList Students;
        public List<Teacher> Teachers;

        public Course(string courseName) {
            _courseName = courseName;

            Students = new ArrayList(3);
            Teachers = new List<Teacher>(3);

        }

        public void ListStudents() {
            foreach (Object o in this.Students) {
                Student s = (Student)o;
                Console.WriteLine(s.FirstName + " " + s.LastName);

            }
        }

    }

    public class UProgram
    {
        private string _uprogramName { get; set; }
        public string UProgramName {
            get { return _uprogramName; }
            set { _uprogramName = value; }
        }
        public Degree Degree;

        public UProgram(string uprogramname) {
            _uprogramName = uprogramname;

        }


    }

    public class Degree
    {
        private string _degreeName { get; set; }
        public string DegreeName {
            get { return _degreeName; }
            set { _degreeName = value; }
        }

        public Course Course;

        public Degree(string name) {

            _degreeName = name;
        }

    }

}