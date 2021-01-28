using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev
{
    class bank2
    {
        // Имя Фамилия\
        // ID клиента
        // Процент1
        // Кол-во денег на счету
        // сгенерировать
        public delegate void prikol(string mes);
        public delegate void smena(string mes);
        public event prikol SMS = (string mes) => { Console.WriteLine(mes); };
        private string _name;
        private int _number;
        private string _surname;
        public string _id;
        private static double _rate;
        private double _paymentAccount;
        private int _SetDATAROZHDENIYA;
        private DateTime _accountOpenDate;
        public string SetName
        {
            get { return _name; }
            set
            {
                _name = value;
                SMS?.Invoke($"Имя сменили на: {_name}");
            }
        }
        public void Setnumb(int newNumb)
        {
            newNumb = Convert.ToInt32(Console.ReadLine());
        }
        public void SetFamiliya(string newFam)
        {
            newFam = newFam.Trim();
            var firstLetter = newFam[0];
            var otherLetters = newFam.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public void SetID(string newID)
        {
            Random rnd3 = new Random();
            int _id1 = rnd3.Next(100, 250);
            Random rnd2 = new Random();
            int _id2 = rnd2.Next(250, 500);
            Random rnd1 = new Random();
            int _id3 = rnd1.Next(500, 750);
            Random rnd0 = new Random();
            int _id4 = rnd0.Next(750, 1000);
            // сначала ген 4 числа, потом делим на 4 числа
            Random rnd5 = new Random();
            int _id5 = rnd5.Next(2,20);
            Random rnd6 = new Random();
            int _id6 = rnd6.Next(20, 40);
            Random rnd7 = new Random();
            int _id7 = rnd7.Next(40, 60);
            Random rnd8 = new Random();
            int _id8 = rnd8.Next(60, 80);
            Random rnd9 = new Random();
            int _idconech = rnd9.Next(1, 10);
            int id = (_id1 / _id5 + _id2 / _id6 + _id3 / _id7 + _id4 / _id8) * _idconech;
        }
        public double chet;
        double _paymentaccount = Convert.ToDouble(Console.ReadLine());
        public void SetDenRozhd(int newDR)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 14)
                Console.WriteLine("-");
            else
                Console.WriteLine("+");
        }
        public void rabota()
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("Положить на счет - 1, снять - 2, положить на депозит 3");
            int dei = Convert.ToInt32(Console.ReadLine());
            switch (dei)
            {
                case 1:
                    Console.WriteLine("Вы выбрали снять со счета");
                    Console.WriteLine("Введите сумму");
                    double summa = Convert.ToDouble(Console.ReadLine());
                    double chet = _paymentaccount - summa;
                    Console.WriteLine($"Итоговый счет {chet}");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали положить на счет");
                    Console.WriteLine("Введите сумму");
                    double raznost = Convert.ToDouble(Console.ReadLine());
                    chet = _paymentaccount - raznost;
                    Console.WriteLine($"Итоговый счет {chet}");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали депозит");
                    Console.WriteLine("Выберите какую сумму хотите положить");
                    Console.WriteLine("Процент в нашем банке - 0,3859195 в год");
                    double summmmmmmmmmmmm = Convert.ToDouble(Console.ReadLine());
                    double depoz = summmmmmmmmmmmm * 0.3859195;
                    Console.WriteLine($"Через год вы получит {depoz}");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        public static void cashback()
        {
            // разделить на 3 партнера, 1 - 10%, 2 - 20%, 3 - 30
            double potr = Convert.ToDouble(Console.ReadLine());
            string part = Console.ReadLine();
            double cash = 0;
            switch (part)
            {
                case "сбер":
                    cash = potr / 10;
                    break;
                case "акбарс":
                    cash = potr / 20;
                    break;
                case "тинькофф":
                    cash = potr / 30;
                    break;
            }
        }
        public DateTime AccountOpenDate
        {
            get
            {
                return _accountOpenDate;
            }
        }
        public void Cashback(DateTime currentTime, int period)
        {
            int deltaTime = currentTime.Second - _accountOpenDate.Second;
            for (int i = 0; i < deltaTime / period; i++)
            {
                chet += (int)(chet * _rate);
            }
        }
    }
    class Bank
    {
        public string Name;
        public string Surname;
        public int Age;
        public int Id;
        public DateTime dayOfBirth;
        public Bank(string name, string surname, int age, int id, DateTime data)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = DateTime.Now.Year - dayOfBirth.Year;
            dayOfBirth = data;
        }
    }
    class Progr
    {
        public static void BList()
        {
            List<Bank> Banklist = new List<Bank>();
            Banklist.Add(new Bank("Имя1", "Фамилия1", 20, 1, new DateTime(2000,1,1)));
            Banklist.Add(new Bank("Имя2", "Фамилия2", 25, 2, new DateTime(1995,1,2)));
            Banklist.Add(new Bank("Имя3", "Фамилия3", 26, 3, new DateTime(1994,1,3)));
            Banklist.Add(new Bank("Имя4", "Фамилия4", 19, 4, new DateTime(2001, 1, 4)));
            Banklist.Add(new Bank("Имя5", "Фамилия5", 5, 5, new DateTime(2015, 1, 5)));
            Banklist.Add(new Bank("Имя6", "Фамилия6", 15, 6, new DateTime(2005, 1, 6)));
            Banklist.Add(new Bank("Имя7", "Фамилия7", 50, 7, new DateTime(1970, 1, 7)));
            Banklist.Add(new Bank("Имя8", "Фамилия8", 38, 8, new DateTime(1982, 1, 8)));
            Banklist.Add(new Bank("Имя9", "Фамилия9", 68, 9, new DateTime(1952, 1, 9)));
            Banklist.Add(new Bank("Имя10", "Фамилия10", 99, 10, new DateTime(1921, 1, 10)));
            Banklist.Add(new Bank("Имя11", "Фамилия11", 120, 11, new DateTime(1900, 1, 11)));
            ChangeName(Banklist, 1, "Имя12");
            ChangeAge(Banklist, 3, 96);
            ChangeID(Banklist, 10, 20);
            ChangeSurname(Banklist, 5, "Фамилия20");
            foreach (var item in Banklist)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
        static void ChangeName(List<Bank> List, int naitiId, string NewName)
        {
            foreach (var item in List)
            {
                if (item.Id == naitiId)
                    item.Name = NewName;
            }
        }
        static void ChangeSurname(List<Bank> List, int naitiId, string NewFam)
            {
                foreach (var item in List)
                {
                    if (item.Id == naitiId)
                        item.Surname = NewFam;
                }
            }
        static void ChangeID(List<Bank> List, int naitiId, int NewID)
        {
            foreach (var item in List)
            {
                if (item.Id == naitiId)
                    item.Id= NewID;
            }
        }
        static void ChangeAge(List<Bank> List, int naitiId, int NewAge)
        {
            foreach (var item in List)
            {
                if (item.Id == naitiId)
                    item.Age = NewAge;
             }
        }
      //  static void ChangeAge1(Dictionary<int,Bank>bankList, int searchId, string newAge)
       // {
  //          bankList[searchId].SetAge(newAge);
    //    }
    }
}