using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev
{
    class LetterFix
    {
        private int numberGroups;
        private string first_name;
        private string last_name;
        public int number_Groups
        {
            set { numberGroups = value; }
            get { return numberGroups; }
        }
        public string First_name

        {
            set
            {
                first_name = $"{value[0].ToString().ToUpper()}" + $"{value.Substring(1)}";
            }
            get { return first_name; }
        }

        public string Last_name
        {
            set
            {
                last_name = $"{value[0].ToString().ToUpper()}" + $"{value.Substring(1)}";
            }
            get { return last_name; }
        }


    }
    class Run
    {
        public static void LetterFix()
        {
            LetterFix student = new LetterFix();
            Console.WriteLine("введите_numberGroups");
            student.number_Groups = int.Parse(Console.ReadLine());
            Console.WriteLine("введите first_name");
            student.First_name = Console.ReadLine();
            Console.WriteLine("введите last_name");
            student.Last_name = Console.ReadLine();
            Console.WriteLine($"name {Last_name} surname:{first_name} groups:{numberGroups}");
        }
    }      
}
        








