namespace Labs216.Garipova
{
    struct Bank1
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 9;
        private int _Account;
        private static int count = 0;
        private int _SetDate;
        private static int _Max = 100000;
        private static int _Min = 10000;
        public Bank1(string setname, string setsurname, string setid, int setaccount, int setdate)
        {
           _name = name;
            _surname = surname;

        }
        class Bank
        {
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = (firstLetter.ToString().ToUpper() + otherLetter);
        }
        public void Setsurname(string newsurname)
        {
            newsurname = newsurname.Trim();
            var Letter = newsurname[0];
            var Lettter = newsurname.Remove(0, 1);
            _surname = (Letter.ToString().ToUpper() + Lettter);
        }
        public string SetId(string newId)
        {
            _id = name + _surname + count;
            count += 1;
        }
        public double Account()
        {
      
        }

    }
}
