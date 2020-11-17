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

        private int _sum;
        private string _phoneNumber;
        private static double _stavka; 
        public Bank(double stavka)
        {
            _stavka = stavka;
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
        public static void DateTimeStavka()
        {

        }
        public static void Cashbaсk()
        {

        }
    }
}
