//@author SM G
using System;


namespace ConsoleApplication1
{
    class Program
    {
        class Person
        {
            /// <summary>
            /// 
            /// </summary>
            private string firstName;
            private string lastName;
            private string birthDate;
            private string addressLine1;
            private string addressLine2;
            private string city;
            private string stateProvince;
            private string zipPostal;
            private string country;
            private string role;
            public Person(string[] args)
            {
                this.firstName = args[0];
                this.lastName = args[1];
                this.birthDate = args[2];
                this.addressLine1 = args[3];
                this.addressLine2 = args[4];
                this.city = args[5];
                this.stateProvince= args[6];
                this.zipPostal = args[7];
                this.country = args[8];
                this.role = args[9];
                

            }
           public string getFirstName()
            {
                return this.firstName;

            }
            public void print()
            {
                Console.WriteLine();
                Console.WriteLine("start********************");
                Console.WriteLine("Person role "+this.role);
                Console.WriteLine(this.firstName+" "+this.lastName);
                Console.WriteLine("DOB: "+this.birthDate);
                Console.WriteLine("Address:");
                Console.WriteLine(this.addressLine1 + " " + this.addressLine2);
                Console.WriteLine(this.city + " " + this.stateProvince);
                Console.WriteLine(this.zipPostal+ " " + this.country);
                Console.WriteLine("********************end");
                Console.WriteLine();

            }

        }
        class UProgram
        {
            private string programName;
            private string departmentHead;
            private string degrees;
            public UProgram(string [] args)
            {
                this.programName = args[0];
                this.departmentHead = args[1];
                this.degrees = args[2];
            }
            public void print()
            {
                Console.WriteLine();
                Console.WriteLine("start********************");
                Console.WriteLine("Program");
                Console.WriteLine(this.programName);
                Console.WriteLine(this.departmentHead);
                Console.WriteLine(this.degrees);
                Console.WriteLine("********************end");
                Console.WriteLine();

            }

        }
        class Degree
        {
            private string name;
            private int credits;
           
            public Degree(string n,int c)
            {
                this.name = n;
                this.credits = c;
               
            }
            public void print()
            {
                Console.WriteLine();
                Console.WriteLine("start********************");
                Console.WriteLine("Degree");
                Console.WriteLine(this.name);
                Console.WriteLine("credits required: "+this.credits);
                Console.WriteLine("********************end");
                Console.WriteLine();

            }

        }
        class Course
        {
            private string name;
            private int credits;
            private int duration;
            private string teacher;

            public Course(string n, int c, int d, string t)
            {
                this.name = n;
                this.credits = c;
                this.duration = d;
                this.teacher = t;

            }
            public void print()
            {
                Console.WriteLine();
                Console.WriteLine("start********************");
                Console.WriteLine("Course");
                Console.WriteLine(this.name);
                Console.WriteLine("credits: " + this.credits);
                Console.WriteLine("Course lasts " +this.duration+" weeks");
                Console.WriteLine("taught by: " + this.teacher);
                Console.WriteLine("********************end");
                Console.WriteLine();

            }

        }
        static void Main(string[] args)
        {
            string[] atts = { "Sophie", "Greene", "1/12/1991", "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK","Student" };
            string[] att = { "Manual", "Zu", "1/12/1937", "30 Other Street", "", "Sheffield", "West Yorkshire", "LE7 9MN", "UK","Teacher" };
            Person student = new Person(atts);
            student.print();
            Person teacher = new Person(att);
            teacher.print();
            //ensure console window stays open
            string[] pAtt = {"Intro to Computer Science","Some Guy","BSc. blah blah" };
            UProgram prog = new UProgram(pAtt);
            prog.print();
            Degree deg = new Degree("Bsc. A M", 72);
            deg.print();
            Course cour = new Course("Intro hbla", 3, 9, "Mr blah Person");
            cour.print();
            Console.Read();
        }
    }
}
