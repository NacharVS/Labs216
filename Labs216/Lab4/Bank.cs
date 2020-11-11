using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Labs216.Lab4
{
    class Bank
    {
        public delegate void Friend(string phonenumber);

        private int _sum;
        private string _phoneNumber;
        private static double _stavka = 6.7;
        private double _score;
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
                Notify?.Invoke(_phoneNumber);
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
        public static void Bank1()
        {
            
        }
        public static void SetStavka()
        {
            double _score = 17000;
            double _stavka = 6.7;
            Console.WriteLine($"Stavka in our bank - {_stavka}%");
            Console.WriteLine($"our score {_score}");
            Console.WriteLine("How many years would you like to withdraw money?");
            double years = double.Parse(Console.ReadLine());
            double i = 0;
            for ( i = 0; i < years; i++)
            {
                i = ((100 * _score) / _stavka) * 100;
            }
            Console.WriteLine($"Your account will have {i} in {years} years");
        }
        public void StavkaChange(double newStavka)
        {

        }
    }
}
