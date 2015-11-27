/****************************************
** Collections
** @author: Sophie M Greene
** @date: 27/11/2015
** 
****************************************/
using System;
using System.Collections;

namespace Module7SF
{
    #region main class
    class Program
    {
        static void Main(string[] args) {
            //Instantiate three Student objects.
            ArrayList stArr = new ArrayList();
            Student[] st = new Student[3];
            st[0] = new Student("Sophie", "Greene", new DateTime(1982, 12, 1),
                       "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK", 4.0);
            st[1] = new Student("Mandy", "Newton", new DateTime(1985, 11, 12),
                       "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK", 3.4);
            st[2] = new Student("Sonia", "Cry", new DateTime(1952, 1, 12),
                         "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK", 2.7);

            double[,] grds = new double[,] { { 90, 30, 89, 90, 60 }, { 20, 50, 80, 70, 60 }, { 91, 92, 89, 77, 98 } };
            //Add 5 grades to the the Stack in the each Student object.
            //(this does not have to be inside the constructor because 
            //you may not have grades for a student when you create 
            //a new student.)
            for (int i = 0; i < grds.GetLength(0); i++) {
                for (int j = 0; j < grds.GetLength(1); j++) {
                    st[i].Grades.Push(grds[i, j]);
                }
                stArr.Add(st[i]);
            }

            //Instantiate a Course object called Programming with C#.
            Course[] courses = new Course[1];
            courses[0] = new Course("Programming with C#", 3, 16);

            //Add the three Student objects to the Students ArrayList inside the Course object
            courses[0].Students = stArr;

            //Instantiate at least one Teacher object.
            Teacher[] tchArr = new Teacher[2];
            tchArr[0] = new Teacher("Manual", "Zu", new DateTime(1970, 1, 1), "30 Other Street",
                        "", "Sheffield", "West Yorkshire", "LE7 9MN", "UK", "Computing");
            tchArr[1] = new Teacher("Handy", "Man", new DateTime(1930, 10, 1), "30 Other Street",
                       "", "Sheffield", "West Yorkshire", "LE7 9MN", "UK", "Mathmatics");

            //Add that Teacher object to your Course object
            courses[0].Teacher = tchArr;

            //Instantiate a Degree object, such as Bachelor.
            Degree[] deg = new Degree[1];
            deg[0] = new Degree("Bachelor Of Science", 84);

            // Add your Course object to the Degree object.
            deg[0].Courses = courses;

            //Instantiate a UProgram object called Information Technology.
            UProgram prog = new UProgram("Information Technology", "Some One");

            //Add the Degree object to the UProgram object.
            prog.Degrees = deg;


            /*Using a foreach loop, iterate over the Students in the
            ArrayList and output their first and last names to the console window.
            (For this exercise you MUST cast the returned object from the ArrayList
            to a Student object.  Also, place each student name on its own line)*/
            Console.WriteLine("Printing Student List");
            int cnt = 1;
            foreach (Student s in courses[0].Students) {
                Console.WriteLine("{0}-{1} {2}", cnt,
                s.FirstName, s.LastName);
                cnt++;
            }
            Console.WriteLine();
            //Call the ListStudents() method from Main().
            courses[0].ListStudents();

            //using casting
            Student stt = (Student)prog.Degrees[0].Courses[0].Students[2];
            Console.WriteLine("using casting");
            Console.WriteLine();
            stt.takeTest();
            Console.WriteLine();


            #region keep console window open
            Console.Write("Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();
            #endregion


        }
    }
    #endregion

    #region Course class
    class Course
    {
        private string _name;
        private int _credits;
        private int _duration;
        private Teacher[] _teacher;
        private ArrayList _students;
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

        internal Teacher[] Teacher {
            get { return _teacher; }
            set { _teacher = value; }
        }

        internal ArrayList Students {
            get { return _students; }
            set { _students = value; }
        }
        #endregion

        public Course(string n, int c, int d) {
            this.Name = n;
            this.Credits = c;
            this.Duration = d;
            this.Students = new ArrayList();
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
    }
    #endregion

    #region Student class  
    class Student : Person
    {

        private double _gpa;
        private Stack _grades;
        public static int studentCnt = 0;

        #region props
        public double Gpa {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public Stack Grades {
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
            this.Grades = new Stack();
            studentCnt++;//add one each time a new student is created

        }
        public void takeTest() {
            Console.WriteLine("Student {0} {1} who has a {2:0.00} GPA and an average grade {3:0.00}%; is taking a test",
                this.FirstName, this.LastName, this.Gpa, this.averageGrade());
        }
        public double averageGrade() {
            double sum = 0;
            int cnt = 0;
            foreach (double g in this.Grades) {
                sum = sum + g;
                cnt++;
            }
            if (cnt > 0)
                return sum / cnt;
            else
                return 0;
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
    class Person
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
    }
    #endregion

    #region Degree class
    class Degree
    {
        private string _name;
        private int _credits;
        private Course[] _courses;

        #region props
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public int Credits {
            get { return _credits; }
            set { _credits = value; }
        }

        internal Course[] Courses {
            get { return _courses; }
            set { _courses = value; }
        }
        #endregion

        public Degree(string n, int c) {
            this.Name = n;
            this.Credits = c;

        }
    }
    #endregion

    #region UProram class
    class UProgram
    {
        private string _programName;
        private string _departmentHead;
        private Degree[] _degrees;

        #region props
        public string ProgramName {
            get { return _programName; }
            set { _programName = value; }
        }

        public string DepartmentHead {
            get { return _departmentHead; }
            set { _departmentHead = value; }
        }

        internal Degree[] Degrees {
            get { return _degrees; }
            set { _degrees = value; }
        }
        #endregion

        public UProgram(string nam, string depH) {
            this.ProgramName = nam;
            this.DepartmentHead = depH;

        }
    }
    #endregion

}
