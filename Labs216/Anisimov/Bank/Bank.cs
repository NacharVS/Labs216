using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Labs216.Anisimov.Bank
{
    class Bank
    {
        DateTime Time = DateTime.Now;
        static object locker = new object();

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

        private AccountContext db = AccountContext.getInstanse();

        private int AgeCalculate(string birthday)
        {
            int age;

            string[] date = birthday.Split(".");

            if (date.Length != 3)
                throw new Exception("Wrong birthday format");

            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = DateTime.Now.Year - int.Parse(date[2]) - 1;
            {
                if (DateTime.Now.Month >= month & DateTime.Now.Day >= day) age = year + 1;
                else age = year;
            }

            if (age < _MinAge)
                throw new Exception($"Your age does not match the required -- {_MinAge}");
            return age;
        }

        public void Open(string name, string surname, string phone, string birthday) 
        {
            if(name == ""|| name == null)
                throw new Exception($"Name is empty");
            if (surname == "" || surname == null)
                throw new Exception($"Surname is empty");
            if (phone == "" || phone == null)
                throw new Exception($"Phone is empty");
            if (birthday == "" || birthday == null)
                throw new Exception($"Birthday is empty");

            Account newAccount = new Account(name, surname, phone, AgeCalculate(birthday));
            newAccount.Open(Time);
        }

        public void Put(int sum, string id)
        {
            Account account = db.GetAccount(new ObjectId(id)).GetAwaiter().GetResult();

            if (sum < _Min)
                throw new Exception("You can't add less than 10 000");

            else account.Put(sum);

            db.Update(account).GetAwaiter().GetResult();
        }

        public void Withdraw(int sum, string id)
        {
            Account account = db.GetAccount(new ObjectId(id)).GetAwaiter().GetResult();

            if (sum > account.Sum)
                throw new Exception($"You have only: {account.Sum}");
            if (sum > _Max)
                throw new Exception("You can't take more than 100 000");

            account.Withdraw(sum);

            db.Update(account).GetAwaiter().GetResult();
        }

        public void Buy(int sum, string id, string organization)
        {
            Account account = db.GetAccount(new ObjectId(id)).GetAwaiter().GetResult();

            Withdraw(sum, id);

            double BonusRate = 0;

            try
            {
                BonusRate = partners[organization];
            }
            finally
            {
                account.Buy(sum, ref BonusRate);
                db.Update(account).GetAwaiter().GetResult();
            }
        }

        public void ChangeRate(string id, double newValue)
        {
            Account account = db.GetAccount(new ObjectId(id)).GetAwaiter().GetResult();

            account.ChangeRate(newValue);

            db.Update(account).GetAwaiter().GetResult();
        }

        public void Close(string id)
        {
            Account account = db.GetAccount(new ObjectId(id)).GetAwaiter().GetResult();

            account.Close();

            db.Remove(account.Id).GetAwaiter().GetResult();
        }

        public void SkipTime(int days)
        {
            lock (locker)
            {
                var collection = db.GetAccounts().GetAwaiter().GetResult();

                Time += TimeSpan.FromDays(days);
                foreach (var item in collection)
                {
                    item.Calculate(Time);
                    item.GetCashBack(Time);
                    db.Update(item).GetAwaiter().GetResult();
                }
            }
        }

        public void EditInfo(string id, int choose, string newValue)
        {
            Account account = db.GetAccount(new ObjectId(id)).GetAwaiter().GetResult();

            if (newValue == null || newValue == "")
                throw new Exception("Неверное значение");
            if (choose == 4)
                newValue = AgeCalculate(newValue).ToString();

            account.EditInfo(choose, newValue);

            db.Update(account).GetAwaiter().GetResult();
        }

        public void Search(string name, string surname, int? age)
        {
            var builder = new FilterDefinitionBuilder<Account>();
            var filter = builder.Empty;
            if (!String.IsNullOrWhiteSpace(name))
                filter = filter & builder.Regex("Name", new BsonRegularExpression(name));
            if (!String.IsNullOrWhiteSpace(surname))
                filter = filter & builder.Regex("Surname", new BsonRegularExpression(surname));
            if (age.HasValue)
                filter = filter & builder.Eq("Age", age.Value);

            var collection = db.GetAccounts(filter).GetAwaiter().GetResult();

            foreach (var item in collection)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"_______\nname\t{item.Name}\nsurname\t{item.Surname}\nphone\t{item.PhoneNumber}\nage\t{item.Age}\nid\t{item.Id}\nsum\t{item.Sum}\n");
                Console.ForegroundColor = tmp;
            }
        }

        public void GetInfo(string id)
        {
            var account = db.GetAccount(new ObjectId(id)).GetAwaiter().GetResult();

            ConsoleColor tmp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"name\t{account.Name}\nsurname\t{account.Surname}\nphone\t{account.PhoneNumber}\nage\t{account.Age}\nid\t{account.Id}\nsum\t{account.Sum}\n");
            Console.ForegroundColor = tmp;
        }

        public void GetList()
        {
            var collection = db.GetAccounts().GetAwaiter().GetResult();

            foreach (var item in collection)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"_______\nname\t{item.Name}\nsurname\t{item.Surname}\nphone\t{item.PhoneNumber}\nage\t{item.Age}\nid\t{item.Id}\nsum\t{item.Sum}\n");
                Console.ForegroundColor = tmp;
            }
        }

    }
}