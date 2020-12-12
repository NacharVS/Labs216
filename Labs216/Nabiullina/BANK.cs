using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class Person
    {
        private string _name;
        private string _surname;
        private DateTime _dayofbirth;
        private string _telephone;
        private string _id;
        public int _age; 

        public string Name => _name;
        public string Surname => _surname;
        public string Telephon => _telephone;
        public int Age => _age;
        public string Id => _id;
        public DateTime BerthDay => _dayofbirth;
        public Person (string name, string surname/*, DateTime datarogdeniya, string telephone, string id*/)
        {
            _name = name;
            _surname = surname;
           /* _dayofbirth = datarogdeniya;
            _telephone = telephone;
            _id = id;*/
            _age = DateTime.Today.Year - _dayofbirth.Year;
        }
        //public void SetVozrast()
        //{

        //     _age = DateTime.Today.Year - _dayofbirth.Year;
        //    Console.WriteLine(_age);
        //}
        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;

        }
        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstLetter = newSurname[0];
            var otherLetters = newSurname.Remove(0, 1);
            _surname = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public void ChangAge(DateTime NewBerthday)
        {
            _age = DateTime.Today.Year - NewBerthday.Year;
        }
        public void ChangName(string NewName)
        {
            _name = NewName;
        }

        public void ChangSurname(string newSurname)
        {
            _surname = newSurname;
        }
        static void ChangeAge(List<Person> list, string Setid, DateTime newBerthDay)
        {
            foreach (var item in list)
            {
                if (item.Id == Setid)
                    item.ChangAge(newBerthDay);
            }

        }

        static void ChangeName(List<Person> list, string Setid, string newName)
        {
            foreach (var item in list)
            {
                if (item.Id == Setid)
                    item.ChangName(newName);
            }

        }
        static void ChangeSurname(List<Person> list, string Setid, string newSurname)
        {
            foreach (var item in list)
            {
                if (item.Id == Setid)
                    item.ChangSurname(newSurname);
            }

        }
    }
    class BANK 
    {

        private DateTime _dayofbirth;
        private static double _stavka = 6.7;
        private double _schet;
        private static int stt = 0;
        private double _pokupka;
        

        public BANK(string name, string surname, DateTime vozrast, double schet)
        {

            _dayofbirth = vozrast;
            _schet = schet;

        }


       
        public void SetSchet()
        {

            Console.WriteLine($"On the account now: {_schet}");
            Console.WriteLine(" 1. Withdraw money  \n 2. Put money");
            string b = Console.ReadLine();
            switch (b)
            {
                case "1":
                    Console.WriteLine("Max 200000");
                    double with = double.Parse(Console.ReadLine());
                    if (_schet > with)
                    {
                        if (with > 200000)
                        {
                            Console.WriteLine("NOOOT!!!");
                        }
                        else
                        {
                            Console.WriteLine($"On your account: {_schet -= with} money");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"On your account: {_schet} money");
                    }
                    break;
                case "2":
                    Console.WriteLine("Min 50");
                    double put = double.Parse(Console.ReadLine());
                    if (put < 50)
                    {
                        Console.WriteLine("NOOOT!!!");
                    }
                    else
                    {

                        Console.WriteLine($"On your account: { _schet += put } monney");
                    }
                    break;
            }


        }
        public void SetStavka()
        {

            Console.WriteLine($" Stavka  = {_stavka} ");
            Console.Write(" After how many years do you withdraw money? ");
            double let = double.Parse(Console.ReadLine());
            double c;
            for (int i = 0; i < let; i++)
            {
                _schet += _schet / 100 * _stavka;

            }
            Console.WriteLine($"After {let} years, your account will have an {_schet} amount ");

        }
        /*public void SetId()
        {

            stt += 1;
            Console.WriteLine(_id);
        }*/
        public delegate void AccountStavka(double stavka);
        public event AccountStavka Rate;
        public double Stavka
        {
            get { return _stavka; }
            private  set
            {
                _stavka = value;
                Rate?.Invoke(_stavka);
            }

        }
        public void ChangeRate(double stavka)
        {
            Stavka = stavka;

        }
       
        public void Partners (int partn)
        {
            if (partn == 1)
            {
                //"ostin"
                double o = 20;
                _schet += _pokupka / 100 * o;
                Console.WriteLine(_schet);
            }
            if (partn == 2)
            {
                //sportmaster
                double s = 15;
                _schet += _pokupka / 100 * s;
                Console.WriteLine(_schet);
            }
            if (partn==3)
            {
                //pandora
                double p = 12;
                _schet += _pokupka / 100 * p;
                Console.WriteLine(_schet);
            }
           
           
        }
        public void Pokypka(double pok)
        {
            _pokupka = pok;
            _schet -= _pokupka;
        }
        

    }
}
