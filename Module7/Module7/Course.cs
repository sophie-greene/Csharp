/****************************************
** Collections
** @author: Sophie M Greene
** @date: 27/11/2015
** class Course
****************************************/
using System;
using System.Collections;

namespace Module7
{
    class Course
    {
        private string _name;
        private int _credits;
        private int _duration;
        private Teacher[] _teacher;
        private ArrayList _students;
        public static int courseCnt = 0;

        #region properties
        public string Name
        {
            get{return _name;}
            set{_name = value;}
        }

        public int Credits
        {
            get{return _credits;}
            set{_credits = value;}
        }

        public int Duration
        {
            get{return _duration;}
            set{ _duration = value;}
        }

        internal Teacher[] Teacher
        {
            get{ return _teacher;}
            set{ _teacher = value;}
        }

        internal ArrayList Students
        {
            get {return _students;}
            set{ _students = value;}
        }
        #endregion

        public Course(string n, int c, int d)
        {
            this.Name = n;
            this.Credits = c;
            this.Duration = d;
            this.Students = new ArrayList();
            courseCnt++;
        }
        public void ListStudents()
        {
            Console.WriteLine();
            Console.WriteLine("Printing Student List from Class Course");
            int cnt = 1;//student counter
            foreach (Student s in this.Students)
            {
                Console.WriteLine("{0}-{1} {2}", cnt,
                s.FirstName, s.LastName);
                Console.Write("Grades: ");
                foreach (double g in s.Grades)
                {
                    Console.Write("{0},",g);
                }
                Console.WriteLine("Average {0:0.00}%",s.averageGrade());

                cnt++;
            }
            Console.WriteLine();
        }
    }
}
