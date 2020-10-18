using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Lab2
{
    struct Students
    {
        public string _name;
        public string _surname;
        public int _numberGroups;

        public Students(string name, string surname, int numberGroups)
        {
            _name = name;
            _surname = surname;
            _numberGroups = numberGroups;
        }
    }
    class LetterFix
    {
        static public void LetterFix1()
        {
            Students[] StudentFacts = new Students[5];
            StudentFacts[0] = new Students("Aleksey", "Scherbakov", 216);
            StudentFacts[1] = new Students("Nurlan", "Saburov", 216);
            StudentFacts[2] = new Students("Rustem", "Reptiloid", 216);
            StudentFacts[3] = new Students("Tambi", "Masaev", 216);
            StudentFacts[4] = new Students("Sergey", "Dyat'kov", 216);
            string world = Console.ReadLine();
            foreach (var item in StudentFacts)
            {
                if (item._name == world)
                    Console.WriteLine($"name:{item._name} surname:{item._surname} groups:{item._numberGroups}");
            }
        }
    }
}
