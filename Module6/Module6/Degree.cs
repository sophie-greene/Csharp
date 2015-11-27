/****************************************
** More OOP
** @author: Sophie M Greene
** @date: 27/11/2015
** class Degree
****************************************/
using System;


namespace Module6
{
    class Degree
    {
        private string _name;
        private int _credits;
        private Course [] _courses;
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

        internal Course[] Courses
        {
            get
            {
                return _courses;
            }

            set
            {
                _courses = value;
            }
        }

        public Degree(string n, int c)
        {
            this.Name = n;
            this.Credits = c;

        }
    }
}
