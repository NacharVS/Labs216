using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Labs216.Lab4
{
    class Bank
    {
        public delegate void Friend(int sum, string phonenumber);
        public delegate void Texture(double stavka);
        public delegate void Candy(int sum);

        private static int _sum;
        private string _phoneNumber;
        private static double _stavka;
        static double _cashback = 0.05;
        public Bank(double stavka)
        {
            _stavka = stavka;
        }
        public Bank(int sum)
        {
            _sum = sum;
        }
        public Bank(int sum, string phoneNumber)
        {
            _sum = sum;
            _phoneNumber = phoneNumber;
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
                Notify?.Invoke(_sum, _phoneNumber);
            }
        }
        public event Friend Notify;
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            private set
            {
                _phoneNumber = value;
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
            Sum -= sum;
        }
        public void StavkaChange(double stavka)
        {
            stavka = (stavka * Sum) / 100 ;
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
                Notify3.Invoke(_sum);
            }
        }
        public  void Buy(int sum)
        {
            double partner1 = 0.08;
            double partner2 = 0.03;
            for (double i = 0; i < sum; i++)
            {
                if (i < 500)
                {
                    _cashback = sum * partner1;
                }
                else
                {
                    _cashback = sum * partner2;
                }
            }
        }
    }
}
