/****************************************
** Intro to OOP
** @author: Sophie M Greene
** @date: 26/11/2015
** class Course
****************************************/
using System;


namespace Module5
{
    class Course
    {
        private string _name;
        private int _credits;
        private int _duration;
        private Teacher[] _teacher;
        private Student[] _students;
        public static int courseCnt = 0;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Credits
        {
            get
            {
                return _credits;
            }

            set
            {
                _credits = value;
            }
        }

        public int Duration
        {
            get
            {
                return _duration;
            }

            set
            {
                _duration = value;
            }
        }

      

        internal Teacher[] Teacher
        {
            get
            {
                return _teacher;
            }

            set
            {
                _teacher = value;
            }
        }

        internal Student[] Students
        {
            get
            {
                return _students;
            }

            set
            {
                _students = value;
            }
        }

        public Course(string n, int c, int d)
        {
            this.Name = n;
            this.Credits = c;
            this.Duration = d;
            courseCnt++;
        }
    }
}
