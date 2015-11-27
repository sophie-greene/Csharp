/****************************************
** More OOP
** @author: Sophie M Greene
** @date: 27/11/2015
** class Student
****************************************/
using System;

namespace Module6
{
    class Student:Person
    {

        private double _gpa;
        public static int studentCnt=0;

        public double Gpa
        {
            get
            {
                return _gpa;
            }

            set
            {
                _gpa = value;
            }
        }

        public Student(string first, string last, DateTime dob, string address1,
            string address2, string ciy, string stte, string zip, string country,double gpa) : 
            base(first, last, dob, address1, address2, ciy, stte, zip, country)//call parent constructor
        {
           this.Gpa=gpa;
            studentCnt++;//add one each time a new student is created

        }
        public void takeTest()
        {
            Console.WriteLine("{0} {1} who has a {2:0.00} GPA; is taking a test",
                this.FirstName,this.LastName,this.Gpa);
        }
    }
}
