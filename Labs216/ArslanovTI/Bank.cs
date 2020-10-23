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

        public void SetName (string newName) 
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
            int id = rnd.Next(99999,100000);
        }
        public void SetRate(string newsurName)
        {
            
            double rate = 0.13;
            _rate = 0.13 * sum;
            
            
        }
        public void setAddMoney (string newAddMoney)// Положить деньги
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










    }
}
