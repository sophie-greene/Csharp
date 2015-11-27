/****************************************
** More OOP
** @author: Sophie M Greene
** @date: 27/11/2015
** class Program; the main test unit
****************************************/
using System;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate three Student objects.
            Student[] stArr = new Student[3];
            stArr[0] = new Student("Sophie", "Greene", new DateTime(1982, 12, 1),
                        "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK",4.0);
            stArr[1] = new Student("Mandy", "Newton", new DateTime(1985, 11, 12),
                        "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK",3.4);
            stArr[2] = new Student("Sonia", "Cry", new DateTime(1952, 1, 12),
                        "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK",2.7);

            //Instantiate a Course object called Programming with C#.
            Course[] courses = new Course[1];
            courses[0] = new Course("Programming with C#", 3, 16);

            //Add your three students to this Course object.
            courses[0].Students = stArr;

            //Instantiate at least one Teacher object.
            Teacher[] tchArr = new Teacher[2];
            tchArr[0] = new Teacher("Manual", "Zu", new DateTime(1970, 1, 1), "30 Other Street",
                        "", "Sheffield", "West Yorkshire", "LE7 9MN", "UK","Computing");
            tchArr[1] = new Teacher("Handy", "Man", new DateTime(1930, 10, 1), "30 Other Street",
                       "", "Sheffield", "West Yorkshire", "LE7 9MN", "UK","Mathmatics");

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

            /*Using Console.WriteLine statements, output the following information to the console window:
                The name of the program and the degree it contains
                The name of the course in the degree
                The count of the number of students in the course.*/
            Console.WriteLine("The {0} program contains the {1}",prog.ProgramName,prog.Degrees[0].Name);
            Console.WriteLine();
            Console.WriteLine("The {0} degree contains the course {1}", prog.Degrees[0].Name, prog.Degrees[0].Courses[0].Name);
            Console.WriteLine();
            Console.WriteLine("The {0} course contains {1} student(s) ", prog.Degrees[0].Courses[0].Name, Student.studentCnt);
            Console.WriteLine();
            prog.Degrees[0].Courses[0].Students[0].takeTest();
            Console.WriteLine();
            prog.Degrees[0].Courses[0].Teacher[1].gradeTest();
            Console.WriteLine();
            prog.Degrees[0].Courses[0].Students[1].takeTest();
            Console.WriteLine();
            prog.Degrees[0].Courses[0].Teacher[0].gradeTest();
            Console.WriteLine();

            #region keep console window open
            Console.Write("Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();
            #endregion


        }
    }
}
