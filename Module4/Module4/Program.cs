/****************************************
** Complex Data Structures
** @author: Sophie M Greene
** @date: 26/11/2015
**
****************************************/
using System;
using System.Globalization;

namespace Module4
{
    class Program
    {
        #region structs
        struct Student
        {
            //properties
            public string firstName;
            public string lastName;
            public DateTime birthDate;
            public string addressLine1;
            public string addressLine2;
            public string city;
            public string stateProvince;
            public string zipPostal;
            public string country;
            public Student(string first, string last, DateTime dob, string address1,
                string address2, string ciy, string stte, string zip, string country)
            {

                this.firstName = first;
                this.lastName = last;
                this.birthDate = dob;
                this.addressLine1 = address1;
                this.addressLine2 = address2;
                this.city = ciy;
                this.stateProvince = stte;
                this.zipPostal = zip;
                this.country = country;

            }
        }
        struct Teacher
        {
            //properties
            public string firstName;
            public string lastName;
            public DateTime birthDate;
            public string addressLine1;
            public string addressLine2;
            public string city;
            public string stateProvince;
            public string zipPostal;
            public string country;
            public Teacher(string first, string last, DateTime dob, string address1,
                string address2, string ciy, string stte, string zip, string country)
            {

                this.firstName = first;
                this.lastName = last;
                this.birthDate = dob;
                this.addressLine1 = address1;
                this.addressLine2 = address2;
                this.city = ciy;
                this.stateProvince = stte;
                this.zipPostal = zip;
                this.country = country;

            }
        }
        struct UProgram
        {
            public string programName;
            public string departmentHead;
            public string degrees;
            public UProgram(string nam, string depH, string deg)
            {
                this.programName = nam;
                this.departmentHead = depH;
                this.degrees = deg;
            }
        }
        struct Degree
        {
            public string name;
            public int credits;

            public Degree(string n, int c)
            {
                this.name = n;
                this.credits = c;

            }
        }
        struct Course
        {
            public string name;
            public int credits;
            public int duration;
            public string teacher;

            public Course(string n, int c, int d, string t)
            {
                this.name = n;
                this.credits = c;
                this.duration = d;
                this.teacher = t;

            }
        }
        #endregion structures
        //test unit
        static void Main(string[] args)
        {
            int input = 0;
            // Create an array to hold 5 student structs.
            Student[] stArr = new Student[5];
        LabelM: welMessage();
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input please enter a valid choice");
                goto LabelM;
            }

            switch (input)
            {
                case 1:
                    // Create a struct to represent a student
                    Student st = new Student("Sophie", "Greene", new DateTime(1982, 12, 1),
                        "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK");
                    PrintDetails(st);
                    break;
                case 2:
                    //Create a struct to represent a teacher
                    Teacher tt = new Teacher("Manual", "Zu", new DateTime(1970, 1, 1), "30 Other Street",
                        "", "Sheffield", "West Yorkshire", "LE7 9MN", "UK");
                    PrintDetails(tt);
                    break;
                case 3:
                    //Create a struct to represent a program
                    UProgram prog = new UProgram("Intro to Computer Science", "Some Guy", "BSc. blah blah");
                    PrintDetails(prog);
                    break;
                case 4:
                    // Create a struct to represent a course
                    Course cour = new Course("Intro hbla", 3, 9, "Mr blah Person");
                    PrintDetails(cour);
                    break;
                case 5:

                    //Assign values to the fields in at least one of the student structs in the array
                    //Using a series of Console.WriteLine() statements, output the values for the 
                    //student struct that you assigned in the previous step
                    for (int i = 0; i < stArr.Length; i++)
                    {
                        stArr[i] = new Student("Sophie", "Greene", new DateTime(1982, 12, 1), "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK");
                        Console.WriteLine("student details in Array item number {0}", i);
                        PrintDetails(stArr[i]);
                    }
                    break;
                case 6:
                    #region challenge
                    //challenge: cUse an appropriate looping structure to add values to all student structs 
                    //in the array by prompting a user of the application to enter values for fields.
                    for (int i = 0; i < stArr.Length; i++)
                    {
                        stArr[i] = new Student();
                        GetInformation(out stArr[i]);
                        //array index start at zero so we add one for item number
                        Console.WriteLine("student details in Array item number {0}", i + 1);
                        PrintDetails(stArr[i]);
                    }
                    //challenge: create another loop to iterate over the array and write the values to the console window
                    for (int i = 0; i < stArr.Length; i++)
                    {
                        PrintDetails(stArr[i]);
                    }
                    #endregion
                    break;
                case 7:
                    goto LabelQ;
                    break;
                default:
                    Degree deg = new Degree("Bsc. A M", 72);
                    PrintDetails(deg);
                    break;
            }
            #region clear console
            Console.Write("Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();
            #endregion
            goto LabelM;
        LabelQ:
            #region keep console window open
            Console.Write("Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();
            #endregion

        }

        private static void welMessage()
        {
            Console.WriteLine("Please choose one of the following numerical options followed by the return key");
            Console.WriteLine("1. create student structure");
            Console.WriteLine("2. create teacher structure");
            Console.WriteLine("3. create program structure");
            Console.WriteLine("4. create course structure");
            Console.WriteLine("5. create student structure array of 5 elements");
            Console.WriteLine("6. Challenge: fill student array from user input and display");
            Console.WriteLine("7. Quit");
            Console.WriteLine("Enter a valid 1-6 option >>");
        }

        static void PrintDetails(Student st)
        {

            Console.WriteLine("Student Details");
            Console.WriteLine(st.firstName + " " + st.lastName + " was born on: " + st.birthDate);
            Console.WriteLine("Address: {0} ,{1} ", st.addressLine1, st.addressLine2);
            Console.WriteLine("{0}, {1}, {2} ", st.city, st.stateProvince, st.zipPostal);
            Console.WriteLine(st.country);
            Console.WriteLine("=========");
        }
        //overload for Teacher
        static void PrintDetails(Teacher st)
        {

            Console.WriteLine("Teacher Details");
            Console.WriteLine(st.firstName + " " + st.lastName + " was born on: " + st.birthDate);
            Console.WriteLine("Address: {0} ,{1} ", st.addressLine1, st.addressLine2);
            Console.WriteLine("{0}, {1}, {2} ", st.city, st.stateProvince, st.zipPostal);
            Console.WriteLine(st.country);
            Console.WriteLine("=========");
        }
        //overload for Course
        static void PrintDetails(Course cr)
        {
            Console.WriteLine("Course Details");
            Console.WriteLine("Course's Name : {0}", cr.name);
            Console.WriteLine("Credits earned: {0} ", cr.credits);
            Console.WriteLine("The course lasts {0} weeks", cr.duration);
            Console.WriteLine("Teacher's Name : {0}", cr.teacher);
            Console.WriteLine("=========");
        }
        //overload for Degree
        static void PrintDetails(Degree deg)
        {
            Console.WriteLine("Degree Details");
            Console.WriteLine("Degree's Name : {0}", deg.name);
            Console.WriteLine("Credits required: {0} ", deg.credits);
            Console.WriteLine("=========");
        }
        //overload for UProgram
        static void PrintDetails(UProgram prog)
        {
            Console.WriteLine("UProgram Details");
            Console.WriteLine("Program's Name : {0}", prog.programName);
            Console.WriteLine("Department Head: {0} ", prog.departmentHead);
            Console.WriteLine("Related degrees: {0} ", prog.degrees);
            Console.WriteLine("=========");

        }

        static void GetInformation(out Teacher st)
        {
            DateTimeFormatInfo dtfi = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;
            dtfi.DateSeparator = "/";
            dtfi.ShortDatePattern = @"dd/MM/yyyy";
            Console.WriteLine("Enter the teacher's first name: ");
            st.firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            st.lastName = Console.ReadLine();
        Label: Console.WriteLine("Enter the teacher's date of birth in the {0} format", dtfi.ShortDatePattern);
            try
            {
                st.birthDate = DateTime.Parse(Console.ReadLine(), dtfi);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid date, enter valid format please");
                goto Label;
            }
            Console.WriteLine("Enter the teacher's address line 1 ");
            st.addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's address line 2 ");
            st.addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's city ");
            st.city = Console.ReadLine();
            Console.WriteLine("Enter the teacher's state/province ");
            st.stateProvince = Console.ReadLine();
            Console.WriteLine("Enter the teacher's zip/Postal code ");
            st.zipPostal = Console.ReadLine();
            Console.WriteLine("Enter the teachr's country");
            st.country = Console.ReadLine();
        }
        //overload for Student
        static void GetInformation(out Student st)
        {
            DateTimeFormatInfo dtfi = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;
            dtfi.DateSeparator = "/";
            dtfi.ShortDatePattern = @"dd/MM/yyyy";
            Console.WriteLine("Enter the studet's first name: ");
            st.firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            st.lastName = Console.ReadLine();
        Label: Console.WriteLine("Enter the student's date of birth in the {0} format", dtfi.ShortDatePattern);
            try
            {
                st.birthDate = DateTime.Parse(Console.ReadLine(), dtfi);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid date, enter valid format please");
                goto Label;
            }
            Console.WriteLine("Enter the student's address line 1 ");
            st.addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the student's address line 2 ");
            st.addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the student's city ");
            st.city = Console.ReadLine();
            Console.WriteLine("Enter the student's state/province ");
            st.stateProvince = Console.ReadLine();
            Console.WriteLine("Enter the student's zip/Postal code ");
            st.zipPostal = Console.ReadLine();
            Console.WriteLine("Enter the student's country");
            st.country = Console.ReadLine();
        }
        //overload for struct Course
        static void GetInformation(out Course cr)
        {
            Console.WriteLine("Enter the Course's Name: ");
            cr.name = Console.ReadLine();
        LabelC: Console.WriteLine("Enter the number of credits earned");
            try
            {
                cr.credits = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input, Integer expected");
                goto LabelC;
            }

        LabelD: Console.WriteLine("Enter the duration of the course in weeks");
            try
            {
                cr.duration = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input, Integer expected");
                goto LabelD;
            }

            Console.WriteLine("Enter the teacher's name");
            cr.teacher = Console.ReadLine();
        }
        //overload for Degree
        static void GetInformation(out Degree deg)
        {
            Console.WriteLine("Enter the Degree's Name: ");
            deg.name = Console.ReadLine();
        //read until valid input is provided
        Label: Console.WriteLine("Enter the number of credits required to finish degree");
            try
            {
                deg.credits = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input, Integer expected");
                goto Label;
            }

        }
        //overload for UProgram
        static void GetInformation(out UProgram prog)
        {
            Console.WriteLine("Enter the Prorgam's Name: ");
            prog.programName = Console.ReadLine();
            Console.WriteLine("Enter the department Head's name");
            prog.departmentHead = Console.ReadLine();
            Console.WriteLine("Enter the degrees related to the Program");
            prog.degrees = Console.ReadLine();
        }

    }
}
