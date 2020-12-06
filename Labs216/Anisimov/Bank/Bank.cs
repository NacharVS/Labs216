using System;
using System.Collections.Generic;

namespace Labs216.Anisimov.Bank
{
    class Bank
    {
        List<Account> Accounts = new List<Account>();
        DateTime Time = DateTime.Now;

        Dictionary<string, double> partners = new Dictionary<string, double>()
        {
            { "Macdonalds", 0.05 },
            { "Steam", 0.025},
            { "Apple", 0.02},
            { "Paterochka", 0.05}
        };

        private static readonly int _Max = 1000000;
        private static readonly int _Min = 10000;
        protected static readonly int _MinAge = 14;

        public void Open(string name, string surname, string phone, string birthday) 
        {
            int age;

            string[] date = birthday.Split(".");
            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = DateTime.Now.Year - int.Parse(date[2]) - 1;
            {
                if (DateTime.Now.Month >= month & DateTime.Now.Day >= day) age = year + 1;
                else age = year;
            }

            if (age < _MinAge)
                throw new Exception($"Your age does not match the required -- {_MinAge}");
            Account newAccount = new Account(name, surname, phone, age);
            newAccount.Open();
            Accounts.Add(newAccount);
        }

        public void Put(int sum, int id)
        {
            Account account = null;
            FindAccount(id, ref account);

            if (account == null)
                throw new Exception("Account not found");

            if (sum < _Min)
                throw new Exception("You can't add less than 10 000");
            else account.Put(sum);
        }

        public void Withdraw(int sum, int id)
        {
            Account account = null;
            FindAccount(id, ref account);

            if (account == null)
                throw new Exception("Account not found");

            if (sum > account.Sum)
                throw new Exception($"You have only: {account.Sum}");

            if (sum > _Max)
                throw new Exception("You can't take more than 100 000");

            account.Withdraw(sum);
        }

        public void Buy(int sum, int id, string organization)
        {
            Account account = null;
            FindAccount(id, ref account);

            if (account == null)
                throw new Exception("Account not found");

            Withdraw(sum, id);

            double cashBackRate = 0;

            try
            {
                cashBackRate = partners[organization];
            }
            finally
            {
                account.Buy(sum, ref cashBackRate);
            }
        }

        private void FindAccount(int id, ref Account account)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Id == id)
                {
                    account = Accounts[i];
                }
            }
        }

        public void ChangeRate(int id, double newValue)
        {
            Account account = null;
            FindAccount(id, ref account);

            if (account == null)
                throw new Exception("Account not found");

            account.ChangeRate(newValue);
        }

        public void Close(int id)
        {
            Account account = null;
            FindAccount(id, ref account);

            if (account == null)
                throw new Exception("Account not found");

            account.Close();

            Accounts.Remove(account);
        }

        public void SkipTime(int days)
        {
            Time += TimeSpan.FromDays(days);
            for (int i = 0; i < Accounts.Count; i++)
            {
                Accounts[i].Calculate(Time);
                Accounts[i].GetCashBack(Time);
            }
        }
    }
}