using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Anisimov
{
    class LetterFix
    {
        private string first_name;
        private string last_name;

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

        /*
        LetterFix[] students = new LetterFix[5];
            for (int i = 0;i<5;i++)
            {
                students[i] = new LetterFix();
                Console.WriteLine("Enter first name: ");
                students[i].First_name = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                students[i].Last_name = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{students[i].First_name} {students[i].Last_name}");
            }
        */
    }
}
