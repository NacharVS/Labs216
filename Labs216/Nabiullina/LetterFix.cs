using System;
using System.Collections.Generic;
using System.Text;
using Labs216;

namespace Labs216
{
    class Group
    {
        private string _name;
        private string _surname;
        public Group(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public string Name
        {
            get => _name;
            set
            {
                string purename = null;
                string buff = value.Remove(0, 1);
                purename = purename + value[0].ToString().ToUpper();
                _name = purename + buff;

            }
        }
        public string Surname
        {// van
            get => _surname;
            set
            {
                string puresurname = null;
                string buff = value.Remove(0, 1);
                puresurname = puresurname + value[0].ToString().ToUpper();
                _name = puresurname + buff;
            }
        }
    }
}
