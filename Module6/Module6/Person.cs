/****************************************
** More OOP
** @author: Sophie M Greene
** @date: 27/11/2015
** class Student
****************************************/
using System;


namespace Module6
{
    class Person
    {
        //properties
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _stateProvince;
        private string _zipPostal;
        private string _country;
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                _birthDate = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return _addressLine1;
            }

            set
            {
                _addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return _addressLine2;
            }

            set
            {
                _addressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string StateProvince
        {
            get
            {
                return _stateProvince;
            }

            set
            {
                _stateProvince = value;
            }
        }

        public string ZipPostal
        {
            get
            {
                return _zipPostal;
            }

            set
            {
                _zipPostal = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }
        public Person(string first, string last, DateTime dob, string address1,
          string address2, string ciy, string stte, string zip, string country)
        {

            this.FirstName = first;
            this.LastName = last;
            this.BirthDate = dob;
            this.AddressLine1 = address1;
            this.AddressLine2 = address2;
            this.City = ciy;
            this.StateProvince = stte;
            this.ZipPostal = zip;
            this.Country = country;
           

        }
    }
}
