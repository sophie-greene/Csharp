/****************************************
** Collections
** @author: Sophie M Greene
** @date: 27/11/2015
** class Student
****************************************/
using System;
using System.Collections;

namespace Module7
{
    class Student:Person
    {

        private double _gpa;
        private Stack _grades;
        public static int studentCnt=0;

        #region props
        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public Stack Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }
        #endregion

        public Student(string first, string last, DateTime dob, string address1,
            string address2, string ciy, string stte, string zip, string country,double gpa) : 
            base(first, last, dob, address1, address2, ciy, stte, zip, country)//call parent constructor
        {
           this.Gpa=gpa;
           //initialise grade stack
           this.Grades = new Stack();
           studentCnt++;//add one each time a new student is created

        }
        public void takeTest()
        {
            Console.WriteLine("Student {0} {1} who has a {2:0.00} GPA and an average grade {3:0.00}%; is taking a test",
                this.FirstName,this.LastName,this.Gpa,this.averageGrade());
        }
        public double averageGrade()
        {
            double sum = 0;
            int cnt = 0;
            foreach(double g in this.Grades)
            {
                sum =sum+ g;
                cnt++;
            }
            if (cnt > 0)
                return sum / cnt;
            else
                return 0;
        }
    }
}
