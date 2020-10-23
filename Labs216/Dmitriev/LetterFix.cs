using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Dmitriev
{
    class LetterFix
    {
        private int _numberGroups;
        private string first_name;
        private string last_name;
        public string number_Groups
        {
            set
            {
                number_Groups = $"{value[0].ToString().ToUpper()}" + $"{value.Substring(1)}";
            }
            get { return number_Groups; }
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
            student.number_Groups = Console.ReadLine();
            Console.WriteLine("введите first_name");
            student.First_name = Console.ReadLine();
            Console.WriteLine("введите last_name");
            student.Last_name = Console.ReadLine();
        }
    }
}
        








