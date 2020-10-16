using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev
{
    class LetterFix
    {
        public static void LF()
        {
            Console.WriteLine("Введите имя первого студента");
            string imya1 = Console.ReadLine();
            Console.WriteLine("Введите фамилию первого студента");
            string fam1 = Console.ReadLine();
            Console.WriteLine("Введите имя второго студента");
            string imya2 = Console.ReadLine();
            Console.WriteLine("Введите фамилию второго студента");
            string fam2 = Console.ReadLine();
            Console.WriteLine("Введите имя третьего студента");
            string imya3 = Console.ReadLine();
            Console.WriteLine("Введите фамилию третьего студента");
            string fam3 = Console.ReadLine();
            Console.WriteLine("Введите имя четвертого студента");
            string imya4 = Console.ReadLine();
            Console.WriteLine("Введите фамилию четвертого студента");
            string fam4 = Console.ReadLine();
            Console.WriteLine("Введите имя пятого студента");
            string imya5 = Console.ReadLine();
            Console.WriteLine("Введите фамилию пятого студента");
            string fam5 = Console.ReadLine();
            imya1 = imya1.ToLower();
            imya2 = imya2.ToLower();
            imya3 = imya3.ToLower();
            imya4 = imya4.ToLower();
            imya5 = imya5.ToLower();
            fam1 = fam1.ToLower();
            fam2 = fam2.ToLower();
            fam3 = fam3.ToLower();
            fam4 = fam4.ToLower();
            fam5 = fam5.ToLower();
            imya1 = imya1.ToUpper()[0] + imya1.Substring(1);
            imya2 = imya2.ToUpper()[0] + imya2.Substring(1);
            imya3 = imya3.ToUpper()[0] + imya3.Substring(1);
            imya4 = imya4.ToUpper()[0] + imya4.Substring(1);
            imya5 = imya5.ToUpper()[0] + imya5.Substring(1);
            fam1 = fam1.ToUpper()[0] + fam1.Substring(1);
            fam2 = fam2.ToUpper()[0] + fam2.Substring(1);
            fam3 = fam3.ToUpper()[0] + fam3.Substring(1);
            fam4 = fam4.ToUpper()[0] + fam4.Substring(1);
            fam5 = fam5.ToUpper()[0] + fam5.Substring(1);
            Console.WriteLine($"Имя первого студента {imya1}, Фамилия первого студента {fam1}");
            Console.WriteLine($"Имя второго студента {imya2}, Фамилия первого студента {fam2}");
            Console.WriteLine($"Имя третьего студента {imya3}, Фамилия первого студента {fam3}");
            Console.WriteLine($"Имя четвертого студента {imya4}, Фамилия первого студента {fam4}");
            Console.WriteLine($"Имя пятого студента {imya5}, Фамилия первого студента {fam5}");

        }
    }
}
