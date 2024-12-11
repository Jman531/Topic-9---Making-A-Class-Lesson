using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_9___Making_A_Class_Lesson
{
    internal class Student
    {
        private static Random _generator = new Random();
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _studentNumber;

        public Student(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._studentNumber = _generator.Next(0, 1000) + 555000;
            GenerateEmail();
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                this._firstName = value;
                GenerateEmail();
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
                this._lastName = value;
                GenerateEmail();
            }
        }

        public int StudentNumber
        {
            get
            {
                return _studentNumber;
            }
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }

        public void ResetStudentNumber()
        {
            this._studentNumber = _generator.Next(0, 1000) + 555000;
            GenerateEmail();
        }

        private void GenerateEmail()
        {
            this._email = _firstName.Substring(0, 3) + _lastName.Substring(0, 3) + _studentNumber.ToString().Substring(_studentNumber.ToString().Length - 3);
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }
    }
}
