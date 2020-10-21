using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Nabiullina
{
    class BANK
    {
        public string _name;
        public string _surname;
        public static decimal _stavka;
        public string _id;
        public int _schet;
        public BANK(string name, string surname, decimal stavka, string id, int schet)
        {
            _name = name;
            _surname = surname;
            _stavka = stavka;
            _id = id;
            _schet = schet;

        }
    }
}
