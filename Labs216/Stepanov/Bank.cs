using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Stepanov
{
    class Bank
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate;
        private double _paymentAccount;

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
        public void SetID(string newID)
        {
            newID = newID.Trim();
            var firstLetter = newID[0];
            var otherLetters = newID.Remove(0, 1);
            _id = firstLetter.ToString().ToUpper() + otherLetters;
        }
        public void SetRate(double newRate)
        {
            newRate = newRate.
        }


    }
}
