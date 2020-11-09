﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Lab4
{
    class Bank
    {
        private string _name;
        private string _surname;
        private int _id;
        private static double _stavka;
        private double _score;
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
        public static void Bank1()
        {
            Console.WriteLine("Welcome to our bank!");
            Console.WriteLine("Stavka in our bank - 6,7%");
            Console.WriteLine("Enter your data");
            string data = Console.ReadLine();
        }
    }
}