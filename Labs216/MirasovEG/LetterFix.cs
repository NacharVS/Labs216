using System;

namespace Labs216.MirasovEG
{
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
                    _name = "No Data";
                }
                else
                    _name = $"{value[0].ToString().ToUpper() + value.Substring(1)}";
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == "")
                {
                    _surname = "No Data";
                }
                else
                    _surname = $"{value[0].ToString().ToUpper() + value.Substring(1)}";

            }
        }


        public static void LetterFixMethods()
        {
            LetterFix[] std = new LetterFix[5];
            for (int i = 0; i < 5; i++)
            {
                std[i] = new LetterFix();

                Console.WriteLine("Enter Name:");
                std[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Surname:");
                std[i].Surname = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Student number {i + 1}: {std[i].Name} | {std[i].Surname}");
            }
        }
    }


}
