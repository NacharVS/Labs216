using System;

namespace Labs216.MikhalevVL
{
    class LetterFix
    {
        private string name_string;
        private string surname_string;

        public string Name
        {
            get { return name_string; }
            set
            {
                name_string = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
            }
        }
        public string Surname
        {
            get { return surname_string; }
            set
            {
                surname_string = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
            }
        }
        /*LetterFix[] student = new LetterFix[5];
                for (int i = 0; i< 5; i++)
                {
                    student[i] = new LetterFix();

        Console.WriteLine("Enter Name:");
                    student[i].Name = Console.ReadLine();

                    Console.WriteLine("Enter Surname:");
                    student[i].Surname = Console.ReadLine();
                }

    Console.WriteLine();

                for (int i = 0; i< 5; i++)
                {
                    Console.WriteLine($"Student {i+1} -- {student[i].Name} {student[i].Surname}");
                }*/
    }
}
