using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Shakirov
{
    class Bank1
    {
        public delegate void Friend(int sum, string phonenumber);
        public delegate void Texture(double stavka);

        private int _sum;
        private string _phoneNumber;
        private static double _stavka;
        public Bank1(double stavka)
        {
            _stavka = stavka;
        }

        public Bank1(int sum, string phoneNumber)
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
        public event Friend Notify2;
        public string PhoneNumber;
        {
        get
            {
            return _phoneNumber



