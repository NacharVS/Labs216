namespace Labs216.Garipova
{
    class Student
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
            get { return _firstname; }

            set
            {
                string purrename = null;
                string buf = value.Remove(0, 1);
                purrename = purrename + value[0].ToString().ToUpper();
                firstname = purrename + buf;
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
                string purename = null;
                string buff = value.Remove(0, 1);
                purename = purename + value[0].ToString().ToUpper();
                name = purename + buff;
            }



        }
    }
}
