using System;
using System.Collections.Generic;

namespace Labs216.ArslanovTI
{
    class User
    {
        private string _name;
        private string _surname;
        private DateTime _DayOfBir;
        private long _id;
        public delegate void _change();

        public long id => _id;



        public User(string name, string surname, DateTime DayOfBirt, long id)
        {
            _name = name;
            _surname = surname;
            _DayOfBir = DayOfBirt;
            _id = id;

        }
    }
    class Bank
    {
        private string _name;
        private string _surname;
        private static long _id;
        private static double _rate;
        private double addMoney;
        private double withdrawMoney;
        double sum = 0;
        public string cashback;
        private long number;
        public DateTime DayOfBirth;
        int age;




        public void SetName(string newName)
        {


            newName = newName.Trim();
            var firstletter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = (firstletter.ToString().ToUpper() + otherLetters);

        }
        public void SetsurName(string newsurName)
        {
            newsurName = newsurName.Trim();
            var firstletter = newsurName[0];
            var otherLetters = newsurName.Remove(0, 1);
            _surname = (firstletter.ToString().ToUpper() + otherLetters);
        }
        public void SetId(long newSetId)
        {
            Random rnd = new Random();
            long id = rnd.Next(99999, 100000000);
            id = _id;

        }
        public void SetRate(string newSetRate)
        {

            double rate = 0.13;
            _rate = 0.13 * sum;


        }
        public void setAddMoney(string newAddMoney)// Положить деньги
        {

            int deposite = int.Parse(Console.ReadLine());
            sum = deposite + sum;
            addMoney = sum;

        }
        public void setWithdrawMoney(string newWithdrawMoney)
        {
            int withdraw = int.Parse(Console.ReadLine());
            sum = withdraw + sum;
            withdrawMoney = sum;

        }


        public delegate void Partners(string partn);
        public event Partners Notify;



        public string Cashback1
        {
            get { return cashback; }
            set { Notify?.Invoke($"На счет поступило{sum * 0.1} кэшбека"); }
        }
        public string Cashback2
        {
            get { return cashback; }
            set { Notify?.Invoke($"На счет поступило{sum * 0.3}кэшбека"); }
        }
        public string Cashback3
        {
            get { return cashback; }
            set { Notify?.Invoke($"На счет поступило{sum * 0.3}кэшбека"); }
        }

        public void Users()
        {

            List<User> Users1 = new List<User>();

            Users1.Add(new User("Rudolf", "Nuriev", new DateTime(2002, 5, 8), 35454));
            Users1.Add(new User("Arman", "Bermacker", new DateTime(1953, 5, 8), 36468));
            Users1.Add(new User("Salam", "Alekum", new DateTime(1245, 5, 8), 35448));
            Users1.Add(new User("Sarman", "Nurbiev", new DateTime(2000, 5, 8), 22813));


        }

        public void Change(List<User> list, long id, string newName)
        {
            foreach (var item in list)
            {
                if (item.id == id)
                {
                    list
                }

            }
        }

    }

  

}












    }

