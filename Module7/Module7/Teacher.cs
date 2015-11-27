/****************************************
** Collections
** @author: Sophie M Greene
** @date: 27/11/2015
** class Teacher
****************************************/
using System;

namespace Module7
{
    class Teacher : Person
    {
        private string _mainSubject;
        public static int teacherCnt = 0;

        #region props
        public string MainSubject
        {
            get { return _mainSubject; }
            set { _mainSubject = value; }
        }
        #endregion

        public Teacher(string first, string last, DateTime dob, string address1,
            string address2, string ciy, string stte, string zip, string country, string m) :
                base(first, last, dob, address1, address2, ciy, stte, zip, country)
        {

            this.MainSubject = m;
            teacherCnt++; //add one each time a new teacher is created

        }
        public void gradeTest()
        {
            Console.WriteLine("{0} {1}; the {2} teacher is grading a test",
                this.FirstName, this.LastName, this.MainSubject);
        }
    }
}
