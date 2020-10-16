using System;

namespace Labs216.MikhalevVL
{
    class LetterFix
    {
        private string name_string;
        private string surname_string;

        public string Name
        {
            get { return name_string; }
            set
            {
                name_string = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
            }
        }
        public string Surname
        {
            get { return surname_string; }
            set
            {
                surname_string = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
            }
        }
    }
}
