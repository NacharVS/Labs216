using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Labs216.Lab2
{
    struct Students
    {
        public string _name;
        public string _surname;
        public int _numberGroups;
         
        public Students (string name, string surname, int numberGroups)
        {
            _name = name;
            _surname = surname;
        }
    }
    class LetterFix
    {
        private string _name;
        private string _surname;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "")
                {
                    _name = "no data";
                }
                else
                    _name = $"{ value[0].ToString().ToUpper() + value.Substring(1)}";
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == "")
                {
                    _surname = "no data";
                }
                else
                    _surname = $"{ value[0].ToString().ToUpper() + value.Substring(1)}";
            }
        }
        public static void LetterFix1()
        {
            Students[] std = new Students[5];
            for (int i = 0; i < 5; i++)
            {
                std[i] = new Students();
                Console.WriteLine("Enter name:");
                std[i]._name = Console.ReadLine();
                Console.WriteLine("Enter surname:");
                std[i]._surname = Console.ReadLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Student number {i + 1}: {std[i]._name} | {std[i]._surname}");
            }
        }
    }
}
