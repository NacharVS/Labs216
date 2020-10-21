using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class BANK
    {
        private string _name;
        private string _surname;
        private static decimal _stavka;
        private string _id;
        private int _schet;

        public BANK(string name, string surname, decimal stavka, string id, int schet)
        {
            _name = name;
            _surname = surname;
            _stavka = stavka;
            _id = id;
            _schet = schet;

        }
        public string Name
        {
            get => _name;
            set
            {
              
            }
        }
    }
}
