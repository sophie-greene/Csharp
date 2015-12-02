/****************************************
** Generics
** @author: Sophie M Greene
** @date: 28/11/2015
** 
****************************************/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Module8
{
    #region main class
    class Program
    {
        static void Main(string[] args) {

            //Instantiate a UProgram object called Information Technology.
            UProgram prog = new UProgram("Information Technology", "Some One");
            //Instantiate a Degree object, such as Bachelor.

            prog.Degrees.Add(new Degree("Bachelor Of Science", 84));

            //Instantiate a Course object called Programming with C#.
            prog.Degrees[0].Courses.Add(new Course("Programming with C#", 3, 16));

            /*Grading criterion 3- Added 3 Student objects to this
            List<T> using the List<T> method for adding objects.*/
            prog.Degrees[0].Courses[0].Students.Add(new Student
            ("Sophie", "Greene", new DateTime(1982, 12, 1),
            "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK", 4.0));
            prog.Degrees[0].Courses[0].Students.Add(new Student
            ("Mandy", "Newton", new DateTime(1985, 11, 12),
            "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK", 3.4));
            prog.Degrees[0].Courses[0].Students.Add(new Student
            ("Sophie", "Cry", new DateTime(1952, 1, 12),
            "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK", 2.7));

            double[,] grds = new double[,]
            { { 90, 30, 89, 90, 60 },
{ 20, 50, 80, 70, 60 },
{ 91, 92, 89, 77, 98 } };

            //Add 5 grades to the the Stack in the each Student object.
            //(this does not have to be inside the constructor because 
            //you may not have grades for a student when you create 
            //a new student.)
            for (int i = 0; i < grds.GetLength(0); i++) {
                for (int j = 0; j < grds.GetLength(1); j++) {
                    prog.Degrees[0].Courses[0].Students[i].Grades.Push(grds[i, j]);
                }
            }
            //Instantiate at least one Teacher object.
            prog.Degrees[0].Courses[0].Teachers.Add(new Teacher
            ("Manual", "Zu", new DateTime(1970, 1, 1), "30 Other Street",
            "", "Sheffield", "West Yorkshire", "LE7 9MN", "UK", "Computing"));
            prog.Degrees[0].Courses[0].Teachers.Add(new Teacher
            ("Handy", "Man", new DateTime(1930, 10, 1), "30 Other Street",
            "", "Sheffield", "West Yorkshire", "LE7 9MN", "UK", "Mathmatics"));

            //results output
            int input = 0;
            //exists only of input is 6
            while (input != 6) {
                bool isVal = false;
                do {
                    welMessage();
                    isVal = int.TryParse(Console.ReadLine(), out input);
                } while (!isVal);
                switch (input) {
                    case 1:
                        Console.Clear();
                        /*Grading criterion 4- Used a foreach loop to output 
                        the first and last name of each Student in the List<T>.*/
                        Console.WriteLine("Printing Student List");
                        int cnt = 1;
                        foreach (Student s in prog.Degrees[0].Courses[0].Students) {
                            Console.WriteLine("{0}-{1} {2}", cnt,
                            s.FirstName, s.LastName);
                            cnt++;
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Before Sort >>>>");
                        prog.Degrees[0].Courses[0].ListStudents();
                        //sort students
                        sortArr(prog.Degrees[0].Courses[0].Students);
                        Console.WriteLine("After Sort >>>>");
                        //show students
                        prog.Degrees[0].Courses[0].ListStudents();

                        break;
                    case 3:
                        //Call the ListStudents() method from Main().
                        Console.Clear();
                        prog.Degrees[0].Courses[0].ListStudents();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Before Grade Change >>>>");
                        //show students
                        prog.Degrees[0].Courses[0].ListStudents();
                        //remove last grade 
                        double g = prog.Degrees[0].Courses[0].Students[1].Grades.Pop();
                        Console.WriteLine("Grade {0} was updated to 99 for student {1} {2}",
                        g, prog.Degrees[0].Courses[0].Students[1].FirstName,
                        prog.Degrees[0].Courses[0].Students[1].LastName);
                        //add new grade
                        prog.Degrees[0].Courses[0].Students[1].Grades.Push(99);
                        Console.WriteLine("After Grade Change >>>>");
                        //show students
                        prog.Degrees[0].Courses[0].ListStudents();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Before Grade Sort >>>>");
                        //show students
                        prog.Degrees[0].Courses[0].ListStudents();

                        Console.WriteLine("AfterGrade Sort >>>>");
                        //Call the ListStudentsSortedGrds() method from Main().
                        prog.Degrees[0].Courses[0].ListStudentsSortedGrds();
                        break;

                    default:

                        break;
                }
                #region clear console
                Console.Write("Press Any Key to Continue");
                Console.ReadKey();
                Console.Clear();
                #endregion
            }

            #region keep console window open
            Console.Write("Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();
            #endregion

        }
   
        static void sortArr(List<Student> a) {
            //possible because Student parent class "Person" implements IComparable
            a.Sort();
            //int n = a.Count;

            //for (int i = 0; i < n; i++) {

            //    for (int j = i; j > 0 && a[i]< a[j - 1]; j--) {
            //        exch(a, j, j - 1);

            //    }
            //}
        }

        private static void exch(List<Student> a, int i, int j) {
            Student swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }

        private static void welMessage() {
            Console.WriteLine("Please choose one of the following numerical options followed by the return key");
            Console.WriteLine("1. Display Student List");
            Console.WriteLine("2. Display Student Sorted List");
            Console.WriteLine("3. Run StudentList()");
            Console.WriteLine("4. Display Changing Grade");
            Console.WriteLine("5. Sort Grades for all students and display");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Enter a valid 1-6 option >>");
        }

    }
    #endregion

    #region Course class
    class Course
    {
        private string _name;
        private int _credits;
        private int _duration;
        private List<Teacher> _teachers;

        //Grading criterion 1-Used a List<T> collection of the proper data type,
        //inside the Course object.
        private List<Student> _students;
        public static int courseCnt = 0;

        #region properties
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public int Credits {
            get { return _credits; }
            set { _credits = value; }
        }

        public int Duration {
            get { return _duration; }
            set { _duration = value; }
        }

        internal List<Teacher> Teachers {
            get { return _teachers; }
            set { _teachers = value; }
        }

        internal List<Student> Students {
            get { return _students; }
            set { _students = value; }
        }
        #endregion

        public Course(string n, int c, int d) {
            this.Name = n;
            this.Credits = c;
            this.Duration = d;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
            courseCnt++;
        }
        public void ListStudents() {
            Console.WriteLine();
            Console.WriteLine("Printing Student List from Class Course");
            int cnt = 1;//student counter
            foreach (Student s in this.Students) {
                Console.WriteLine("{0}-{1} {2}", cnt,
                s.FirstName, s.LastName);
                Console.Write("Grades: ");
                foreach (double g in s.Grades) {
                    Console.Write("{0},", g);
                }
                Console.WriteLine("Average {0:0.00}%", s.averageGrade());

                cnt++;
            }
            Console.WriteLine();
        }
        public void ListStudentsSortedGrds() {
            Console.WriteLine();
            Console.WriteLine("Printing Student List from Class Course with grades sorted");
            int cnt = 1;//student counter
            foreach (Student s in this.Students) {
                Console.WriteLine("{0}-{1} {2}", cnt,
                s.FirstName, s.LastName);
                s.sortGrades();
                Console.Write("Grades: ");
                foreach (double g in s.Grades) {
                    Console.Write("{0},", g);
                }
                Console.WriteLine("Average {0:0.00}%", s.averageGrade());

                cnt++;
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region Student class 
    class Student : Person,IComparable<Student>
    {

        private double _gpa;

        /*Grading criterion 2-Added a Stack<T> of the proper data type,
        called Grades, inside the Student object.*/
        private Stack<double> _grades;

        public static int studentCnt = 0;

        #region props
        public double Gpa {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public Stack<double> Grades {
            get { return _grades; }
            set { _grades = value; }
        }


        #endregion

        public Student(string first, string last, DateTime dob, string address1,
        string address2, string ciy, string stte, string zip, string country, double gpa) :
        base(first, last, dob, address1, address2, ciy, stte, zip, country)//call parent constructor
        {
            this.Gpa = gpa;
            //initialise grade stack
            this.Grades = new Stack<double>();

            studentCnt++;//add one each time a new student is created

        }
        public void takeTest() {
            Console.WriteLine("Student {0} {1} who has a {2:0.00} GPA and an average grade {3:0.00}%; is taking a test",
            this.FirstName, this.LastName, this.Gpa, this.averageGrade());
        }
        public void sortGrades() {
            /*challenge: find a Generic collection to store grades in a sorted order.*/


            List<double> sar = new List<double>(this.Grades);
            sar.Sort();
            this.Grades = new Stack<double>(sar);
        }
        public void displaySorted() {
            sortGrades();
            Console.WriteLine("Student {0} {1} who has a {2:0.00} GPA and an average grade {3:0.00}%; is taking a test",
            this.FirstName, this.LastName, this.Gpa, this.averageGrade());
        }
        public double averageGrade() {
            double sum = 0;
            int cnt = 0;
            foreach (Double g in this.Grades) {
                sum = sum + g;
                cnt++;
            }
            if (cnt > 0)
                return sum / cnt;
            else
                return 0;
        }
     int IComparable<Student>.CompareTo(Student other) {
            if (this.FirstName.CompareTo(other.FirstName) == 0)
                return this.LastName.CompareTo(other.LastName);
            return this.FirstName.CompareTo(other.FirstName);
        }
 
        public static bool operator <(Student c1, Student c2) {
            if (c1.FirstName.CompareTo(c2.FirstName) == 0)
                return c1.LastName.CompareTo(c2.LastName) < 0;
            return c1.FirstName.CompareTo(c2.FirstName)<0; 
        }
        public static bool operator >(Student c1, Student c2) {
            if (c1.FirstName.CompareTo(c2.FirstName) == 0)
                return c1.LastName.CompareTo(c2.LastName) > 0;
            return c1.FirstName.CompareTo(c2.FirstName) > 0; 
        }
    
    }
    #endregion

    #region Teacher class
    class Teacher : Person
    {
        private string _mainSubject;
        public static int teacherCnt = 0;

        #region props
        public string MainSubject {
            get { return _mainSubject; }
            set { _mainSubject = value; }
        }
        #endregion

        public Teacher(string first, string last, DateTime dob, string address1,
        string address2, string ciy, string stte, string zip, string country, string m) :
        base(first, last, dob, address1, address2, ciy, stte, zip, country) {

            this.MainSubject = m;
            teacherCnt++; //add one each time a new teacher is created

        }
        public void gradeTest() {
            Console.WriteLine("{0} {1}; the {2} teacher is grading a test",
            this.FirstName, this.LastName, this.MainSubject);
        }
    }
    #endregion

    #region Person class
    class Person : IComparable<Person>
    {
        //properties
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _stateProvince;
        private string _zipPostal;
        private string _country;

        #region props
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime BirthDate {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public string AddressLine1 {
            get { return _addressLine1; }
            set { _addressLine1 = value; }
        }

        public string AddressLine2 {
            get { return _addressLine2; }
            set { _addressLine2 = value; }
        }

        public string City {
            get { return _city; }
            set { _city = value; }
        }

        public string StateProvince {
            get { return _stateProvince; }
            set { _stateProvince = value; }
        }

        public string ZipPostal {
            get { return _zipPostal; }
            set { _zipPostal = value; }
        }

        public string Country {
            get { return _country; }
            set { _country = value; }
        }
        #endregion

        public Person(string first, string last, DateTime dob, string address1,
        string address2, string ciy, string stte, string zip, string country) {
            this.FirstName = first;
            this.LastName = last;
            this.BirthDate = dob;
            this.AddressLine1 = address1;
            this.AddressLine2 = address2;
            this.City = ciy;
            this.StateProvince = stte;
            this.ZipPostal = zip;
            this.Country = country;
        }
        int IComparable<Person>.CompareTo(Person other) {
            if (this.FirstName.CompareTo(other.FirstName) == 0)
                return this.LastName.CompareTo(other.LastName);
            return FirstName.CompareTo(other.FirstName);
        }
    }
    #endregion

    #region Degree class
    class Degree
    {
        private string _name;
        private int _credits;
        private List<Course> _courses;

        #region props
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public int Credits {
            get { return _credits; }
            set { _credits = value; }
        }

        internal List<Course> Courses {
            get { return _courses; }
            set { _courses = value; }
        }
        #endregion

        public Degree(string n, int c) {
            this.Name = n;
            this.Credits = c;
            this.Courses = new List<Course>();

        }
    }
    #endregion

    #region UProram class
    class UProgram
    {
        private string _programName;
        private string _departmentHead;
        private List<Degree> _degrees;

        #region props
        public string ProgramName {
            get { return _programName; }
            set { _programName = value; }
        }

        public string DepartmentHead {
            get { return _departmentHead; }
            set { _departmentHead = value; }
        }

        internal List<Degree> Degrees {
            get { return _degrees; }
            set { _degrees = value; }
        }
        #endregion

        public UProgram(string nam, string depH) {
            this.ProgramName = nam;
            this.DepartmentHead = depH;
            //allocate initial memory
            this.Degrees = new List<Degree>();
        }
    }
    #endregion
}