using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate;
        private double addMoney;
        private double withdrawMoney;
        double sum = 0;
        public string cashback;
         

        public void SetName(string newName)
        {


            newName = newName.Trim();
            var firstletter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = (firstletter.ToString().ToUpper() + otherLetters);

        }
        public void SetsurName(string newsurName)
        {
            newsurName = newsurName.Trim();
            var firstletter = newsurName[0];
            var otherLetters = newsurName.Remove(0, 1);
            _surname = (firstletter.ToString().ToUpper() + otherLetters);
        }
        public void SetId(string newsurName)
        {
            Random rnd = new Random();
            int id = rnd.Next(99999, 100000);
        }
        public void SetRate(string newsurName)
        {

            double rate = 0.13;
            _rate = 0.13 * sum;


        }
        public void setAddMoney(string newAddMoney)// Положить деньги
        {

            int deposite = int.Parse(Console.ReadLine());
            sum = deposite + sum;
            addMoney = sum;

        }
        public void setWithdrawMoney(string newWithdrawMoney)
        {
            int withdraw = int.Parse(Console.ReadLine());
            sum = withdraw + sum;
            withdrawMoney = sum;

        }

        public delegate void Partners(string partn);
        public event Partners Notify;

    //    public void McDonalds(double cashback1)
    //    {
    //        cashback1 = 0.1;

    //        Notify?.Invoke($"На счет поступило{sum * 0.1} кэшбека");

    //    }
    //    public void Apple(double cashback2)
    //    {
    //        cashback2 = 0.3;
    //        Notify?.Invoke($"На счет поступило{sum * 0.3} кэшбека");

    //    }
    //    public void Zara(double cashback3)
    //    {
    //        cashback3 = 0.3;
    //        Notify?.Invoke($"На счет поступило{sum * 0.3} кэшбека");

    //    }
  
    public string Cashback1
        {
            get { return cashback; }
            set { Notify?.Invoke($"На счет поступило{sum * 0.1} кэшбека"); }
        }
             public string Cashback2
        {
            get { return cashback; }
            set { Notify?.Invoke($"На счет поступило{sum * 0.3}кэшбека"); }
        }
        public string Cashback3
        {
            get { return cashback; }
            set { Notify?.Invoke($"На счет поступило{sum * 0.3}кэшбека"); }
        }












    }
}
