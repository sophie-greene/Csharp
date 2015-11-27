/****************************************
** Collections
** @author: Sophie M Greene
** @date: 27/11/2015
** class UProgram
****************************************/

namespace Module7
{
    class UProgram
    {
        private string _programName;
        private string _departmentHead;
        private Degree[] _degrees;

        #region props
        public string ProgramName
        {
            get { return _programName; }
            set { _programName = value; }
        }

        public string DepartmentHead
        {
            get { return _departmentHead; }
            set { _departmentHead = value; }
        }

        internal Degree[] Degrees
        {
            get { return _degrees; }
            set { _degrees = value; }
        }
        #endregion

        public UProgram(string nam, string depH)
        {
            this.ProgramName = nam;
            this.DepartmentHead = depH;
            
        }
    }
}
