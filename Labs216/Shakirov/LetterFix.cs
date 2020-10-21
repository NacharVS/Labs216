using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov
{
    class LetterFix
    {
        private string _firstname;
        private string _name;

        public Student(string firstname, string name)
        {
            _firstname = firstname;
            _name = name;
        }

        public string firstname
        {
            get { return _firstname}

            set
        }
    }
}
