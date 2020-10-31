using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zakirov
{
    class LetterFix
    {
        private string _firstname;
        private string _name;

     
 
       public LetterFix(string firstname, string name)
        {
            _firstname = firstname;
            _name = name;
        }

        public string firstname
        {
            get { return _firstname; }

            set
            {
                string purrname = null;
                string buf = value.Remove(0, 1);
                purrname = purrname + value[0].ToString().ToUpper();
                firstname = purrname + buf;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                string purname = null;
                string buff = value.Remove(0, 1);
                purname = purname + value[0].ToString().ToUpper();
                name = purname + buff;
            }
        }
    }
}


