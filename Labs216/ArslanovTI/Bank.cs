using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI
{
    class User
    {
        private string _name;
        private string _surname;
        private DateTime _DayOfBir;
        private long _id;


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
        void SetAge()
        {
            DateTi
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

            Users1.Add("Rudolf", "Nuriev", DateTimeKind(2005,5,8)) ;
            Users1.Add("Ralph");
            Users1.Add("Timur");
            Users1.Add("Cher");




        }
        public void ()
        {
            List<long> idList = new List<long>();
            
            

        }
    }












    }

