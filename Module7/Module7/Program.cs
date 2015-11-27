/****************************************
** Collections
** @author: Sophie M Greene
** @date: 27/11/2015
** class Program; the main test unit
****************************************/
using System;
using System.Collections;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate three Student objects.
            ArrayList stArr = new ArrayList();
            Student[] st = new Student[3];
            st[0] = new Student("Sophie", "Greene", new DateTime(1982, 12, 1),
                       "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK", 4.0);
            st[1] = new Student("Mandy", "Newton", new DateTime(1985, 11, 12),
                       "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK", 3.4);
            st[2] = new Student("Sonia", "Cry", new DateTime(1952, 1, 12),
                         "30 Some Street", "", "Leeds", "West Yorkshire", "ZE7 3AE", "UK", 2.7);

            double[,] grds = new double [,]{ { 90, 30,89,90,60 }, {20,50,80,70,60}, { 91,92,89,77,98} };
            //Add 5 grades to the the Stack in the each Student object.
            //(this does not have to be inside the constructor because 
            //you may not have grades for a student when you create 
            //a new student.)
            for (int i = 0; i < grds.GetLength(0); i++)
            {
                for (int j = 0; j < grds.GetLength(1); j++)
                {
                    st[i].Grades.Push(grds[i,j]);
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
            foreach (Student s in courses[0].Students)
            {
                Console.WriteLine("{0}-{1} {2}",cnt,
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

}
