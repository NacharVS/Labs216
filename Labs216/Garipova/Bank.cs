using System;
namespace Labs216.Garipova
{
    class Bankaccount
    {
        public delegate void Handler(string phonenumber)

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
            Console.WriteLine($"Вас зовут:{_name} {_surname }");
            Console.WriteLine($"Ваш id :{_id }");
            Console.WriteLine($"{_rate }");
        }
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
        public string Id(string newId)
        {
            _id = _name + _surname + count;
            count += 1;
            return _id;
        }
        public void Setrate()
        {
            double _rate = 0.3;
            _rate = 0.3 * count;
        }
        public void RateChange(double newrate)
        {
            _rate = newrate;
        }
        public void Setaddmoney()
        {
            int deposite = int.Parse(Console.ReadLine());
            count = deposite + count;
            addmoney = count;
        }
        public void Setwithdrawmoney()
        {
            int withdraw = int.Parse(Console.ReadLine());
            count = withdraw + count;
            withdrawmoney = count;
        }


    }
}





