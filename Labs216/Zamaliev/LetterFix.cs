using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev
{
    class Student
    {
        private string _firstname;
        private string _name;

        public Student(string firstname, string name)
        {
            Firstname = firstname;
            Name = name;
        }

        public string Firstname
        {
            get { return _firstname; }

            set
            {
                value = value.Trim();
                string buff = value[0].ToString().ToUpper();
                value = value.Substring(1);
                _firstname = buff + value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                
            }
        }
    }
}