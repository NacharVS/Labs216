using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Zamaliev
{
    class Bank
    {
        public delegate void Putin(int sum, string phonenumber);
        public delegate void Brigada(double stavka);
        public delegate void Candy(int sum, double cashback);
        private int _sum;
        private string _phonenumber;
        public static double _stavka;
        static double _cashback = 0.05;
        public Bank(double stavka)
        {
            _stavka = stavka;
        }
        public Bank(int sum, double cashback, string phonenumber)
        {
            _sum = sum;
            _cashback = cashback;
            _phonenumber = phonenumber;
        }
        //public Bank(int sum, string phonenumber)
        //{
        //    _sum = sum;
        //    _phonenumber = phonenumber;
        //}
        public int Balans
        {
            get
            {
                return _sum;
            }
            private set
            {
                _sum = value;
                Notify?.Invoke(_sum, phonenumber);
            }
        }
        public event Putin Notify;
        public string phonenumber
        {

            get
            {
                return _phonenumber;
            }

            private set
            {
                _phonenumber = value;
            }
        }
        public event Brigada Notify2;
        public double Stavka
        {
            get
            {
                return _stavka;
            }
            private set
            {
                _stavka = value;
                Notify2?.Invoke(_stavka);
            }
        }
        public void Deposit(int sum)
        {
            Balans = sum;
        }
        public void Snyat(int sum)
        {
            Balans -= sum;
        }
        public void StavkaChange(double stavka)
        {
            stavka = (stavka * Balans) / 100;
        }
        public event Candy Notify3;
        public double Cashback
        {
            get
            {
                return _cashback;
            }
            set
            {
                _cashback = value;
                Notify3.Invoke(_sum, Cashback);
            }
        }
        public static void Buy(int sum, double cashback)
        {
            double PartnerMagnit = 0.08;
            double PartnerAshan = 0.1;
            for (double i = 0; i < sum; i++)
            {
                if (i < 500)
                {
                    cashback = sum * PartnerMagnit;
                }
                else
                {
                    cashback = sum * PartnerAshan;
                }
            }

        }
    }
}