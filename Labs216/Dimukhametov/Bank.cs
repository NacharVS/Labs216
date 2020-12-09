using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dimukhametov
{
    class Bank
    {
        public delegate void Friend(int sum, string phonenumber);
        public delegate void Texture(double stavka);
        public delegate void Candy(int sum, double cashback);
        private static int _sum;
        private string _phonenumber;
        private static double _stavka;
        static double _cashback = 0.05;
        public Bank(double stavka)
        {
            _stavka = stavka;
        }
        public Bank(int sum, double cashback)
        {
            _sum = sum;
            _cashback = cashback;
        }
        public Bank(int sum, string phonenumber)
        {
            _sum = sum;
            _phonenumber = phonenumber;
        }
        public int Sum
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
        public event Friend Notify;
        public string phonenumber
        {

            get
            {
                return phonenumber;
            }

            private set
            {
                phonenumber = value;
            }
        }
        public event Texture Notify2;
        public double Stavka
        {
            get
            {
                return _stavka;
            }
            private set
            {
                var oldStavka = _stavka;
                _stavka = value;
                Notify2?.Invoke(_stavka);
            }
        }
        public void Deposit(int sum)
        {
            Sum += sum;
        }
        public void Withdraw(int sum)
        {
            Sum += sum;
        }
        public void StavkaChange(double stavka)
        {
            stavka = (stavka * Sum) / 100;
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
