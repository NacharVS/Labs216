using System;
namespace Labs216.Garipova
{
    class Bankaccount
    {
        public delegate void Handler(int sum, string phonenumber);
        public delegate void Texture(double rate);

        private string _sum;
        private string _phonenumber;
        private static double _rate;
        private static int count = 0;
        private static double _cashback;
        public Bankaccount(double rate)
        {
            _rate = rate;
        }
        public Bankaccount(int sum, string phonenumber)
        {
            _sum = sum;
            _phonenumber = phonenumber;
        }
        public int Summa
        {
            get
            {
                return _sum;
            }
            private set
            {
                _sum = value;
                Notify?.Invoke(_sum, _phonenumber);
            }
        }
        public event Handler Notify;
        public string Phonenumber
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
        public event Texture Notify2;
        public double Rate
        {
            get { return _rate; }
            private set
            {
                var Oldrate = _rate;
                _rate = value;
                Notify2?.Invoke(_rate);
            }
        }
        public void Deposit(int sum)
        {
            Summa += sum;
        }
        public void Withdraw(int sum)
        {
            Summa -= sum;
        }
        public void Change(double rate)
        {
            rate = (rate * Summa) / 100;
        }

        public void CashBack()
        {
            get 
                {
                return _cashback;
                }
            set
            {
                _cashback = value;
                Notify3.Invoke(_sum, _cashback); 
            }
        }
        set
    

    }

}
              





