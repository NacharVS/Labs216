using System;
namespace Labs216.Vail
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 9;
        private static int count = 0;
        private double addmoney;
        private double withdrawmoney;
        private int _year { get; set; }
        private int _month { get; set; }
        public void Getinfo()
        {
            Console.WriteLine($"Ваше имя: {_name} {_surname}");
            Console.WriteLine($"Ваш id: {_id}");
            Console.WriteLine($"{_rate}");
        }
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetter = newName.Remove(0, 1);
            _name = (firstLetter.ToString().ToUpper() + otherLetter);
        }
        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var Letter = newSurname[0];
            var Letter = newSurname(0, 1);
            _surname = (Letter.ToString().ToUpper() + Letter);
        }
        public string Id(string newId)
        {
            _id = _name + _surname + count;
            count += 1;
            return _id;
        }
    }
}
