using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MirasovEG
{
    class LetterFix
    {
        private string _name;
        private string _surname;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "")
                {
                    _name = "No Data";
                }
                else
                _name = $"{value[0].ToString().ToUpper() + value.Substring(1)}" ;
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == "")
                {
                    _surname = "No Data";
                }
                else
                _surname = $"{value[0].ToString().ToUpper() + value.Substring(1)}";

            }
        }
        
    }


}
