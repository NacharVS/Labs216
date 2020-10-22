using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Tarskih
{
    class LetterFix
    {
        private string name;
        private string surname;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                value = value.Trim();
                var firstLetter = value[0];
                var otherLetters = value.Remove(0, 1);
                name = firstLetter.ToString().ToUpper() + otherLetters;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                value = value.Trim();
                var firstLetter = value[0];
                var otherLetters = value.Remove(0, 1);
                surname = firstLetter.ToString().ToUpper() + otherLetters;
            }
        }

    }
    class LetterFixProgram
    {
        public static void StartLetterFixProgramm()
        {
            LetterFix[] Student = new LetterFix[5];
            for (int i = 0; i < 4; i++)
            {
                Student[i] = new LetterFix();
                Console.WriteLine("Введите имя");
                Student[i].Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                Student[i].Surname = Console.ReadLine();
            }
            for (int i = 0; i<4; i++)
            {
                Console.WriteLine(Student[i].Name);
                Console.WriteLine(Student[i].Surname);
            }
        }
            
    }
}
