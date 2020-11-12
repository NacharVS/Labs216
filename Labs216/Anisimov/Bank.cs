using System;

namespace Labs216.Anisimov
{
    class Bank
    {
        public delegate void BankAccount(string phoneNumber, string Message);

        public event BankAccount Notify;

        private string _name;
        private string _surname;
        private string _phoneNumber;
        private string _id;
        private static double _interestRate = 5;
        private double _account;
        private static int _count = 0;
        private static int _Max = 100000;
        private static int _Min = 10000;
        private static int _MinAge = 14;
        private int _age;

        public string Name
        {
            get { return _name; }
            private set 
            {
                if (value != "")
                {
                    value = value.Trim();
                    _name = value[0].ToString().ToUpper() + value.Substring(1);
                }
                else _name = "No data";
            }
        }
        public string Surname
        {
            get { return _surname; }
            private set 
            {
                if (value != "")
                {
                    value = value.Trim();
                    _surname = value[0].ToString().ToUpper() + value.Substring(1);
                }
                else _surname = "No data";
            }
        }
        public int Age
        {
            get { return _age; }
            private set
            {
                if (value >= _MinAge)
                    _age = value;
                else
                    Console.WriteLine("Your age does not match the required");
            }
        }
        public string Id
        {
            get { return _id; }
        }
        public double Account
        {
            get { return _account; }
            private set 
            {
                _account = value;
                Notify?.Invoke(_phoneNumber, $"Acount Change {_account}");
            }
        }
        public static int Count
        {
            get { return _count; }
        }
        private void GenId()
        {
            _id = _name + _surname + "_" + _count;
            _count = _count + 1;
        }
        private void GetAge()
        {
            Console.WriteLine("Write you birthday (dd.mm.yyyy)");
            string[] date = new string[3];
            date = Console.ReadLine().Split(".");
            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = DateTime.Now.Year - int.Parse(date[2]) - 1; 
            {
                if (DateTime.Now.Month >= month & DateTime.Now.Day >= day) Age = year + 1;
                else Age = year;
            }
        }


        public Bank()
        {
            Console.WriteLine("Write you name");
            Name = Console.ReadLine();
            Console.WriteLine("Write you surname");
            Surname = Console.ReadLine();
            Console.WriteLine("Write you phone");
            _phoneNumber = Console.ReadLine();
            GetAge();//Отдельный метод для запроса дня рождения и расчета возраста (мне так удобнее)
            GenId();
        }
        public void Withdraw(int value)
        {
            if (value > _account)
            {
                Notify?.Invoke(_phoneNumber, $"You have only: {Account}");
                return;
            }
            if (value <= _Max)
            {
                Account = Account - value;
            }
            else Notify?.Invoke(_phoneNumber, "You can't take more than 100 000");
        }
        public void Deposit(int value)
        {
            if (value >= _Min)
            {
                Account = Account + value;
            }
            else Notify?.Invoke(_phoneNumber, "You can't add less than 10 000");
        }
        public void Calculate(int year)
        {
            double buff = _account;
            for (int i = 0; i < year;  i++)
            {
                buff = buff + buff *_interestRate/100;
            }
            Notify?.Invoke(_phoneNumber, $"Your balance will be {buff} in {year} years");
        }
        public void ChangeRate(double value)
        {
            _interestRate = value;
            Notify?.Invoke(_phoneNumber, $"New insert rate -- {_interestRate}");
        }
    }
    class RunBank
    {
        public static void _Bank()
        {
            Bank[] acc = new Bank[1];
            for (int i = 0; i < 1; i++)
            {
                acc[i] = new Bank();
                acc[i].Notify += Message;
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"number {i + 1}");
                Console.WriteLine($"Name--{acc[i].Name}");
                Console.WriteLine($"Surname--{acc[i].Surname}");
                Console.WriteLine($"ID--{acc[i].Id}");
                Console.WriteLine($"Age--{acc[i].Age}");
                Console.WriteLine();
            } // Это выврд для проверки правильно ли создаються аккаунты и выбора с каким аккаунтом работать
            int acc_number = 0;
            while (true)
            {
                Console.WriteLine("Which account do you want to work with");
                acc_number = int.Parse(Console.ReadLine()) - 1;
                if (acc_number <= Bank.Count - 1) break;
                else Console.WriteLine("Wrong number");
            }
            while (true)
            {
                Console.WriteLine("What do you want: 1 -- Withdraw money || 2 -- Deposit money || 3 -- Check account || 4 -- Calculate deposit || 5 -- Change rate");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("How much:");
                        acc[acc_number].Withdraw(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("How much:");
                        acc[acc_number].Deposit(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine(acc[acc_number].Account);
                        break;
                    case 4:
                        Console.WriteLine("How many years to calculate");
                        acc[acc_number].Calculate(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("How much:");
                        acc[acc_number].ChangeRate(double.Parse(Console.ReadLine()));
                        break;
                }
                Console.WriteLine("Continue y/n");
                if (Console.ReadLine() == "n")
                    break;
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"number {i + 1}");
                Console.WriteLine($"Name--{acc[i].Name}");
                Console.WriteLine($"Surname--{acc[i].Surname}");
                Console.WriteLine($"ID--{acc[i].Id}");
                Console.WriteLine($"Money--{acc[i].Account}");
                Console.WriteLine($"Age--{acc[i].Age}");
                Console.WriteLine();
            }// Это вывод для проверки правильно ли программа работала с данными
        }
        private static void Message(string PhoneNumber, string message)
        {
            Console.WriteLine($"Было отправлено сообщение на номер: {PhoneNumber}");
            Console.WriteLine($"Сообщение: {message}");
            Console.WriteLine();
        }
    }
}
