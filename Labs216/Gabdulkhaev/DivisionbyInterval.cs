using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev
{
    class DivisionByInterval
    {
        public static void Division()
        {
            Console.WriteLine("Деление одного числа на интервал чисел");
            Console.WriteLine("Введите число, которое необходимо разделить на интервал");
            double chislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ваше число={chislo}");
            Console.WriteLine("Введите начальное число интервала");
            double nachalo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечное число интервала");
            double konec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Начальное число интервала - {nachalo}, конечное чисел - {konec}");
            for (double a = nachalo; a <= konec; a = a + 1)
            {
                double otvet = chislo / a;
                Console.WriteLine($"При делении {chislo} на {a} получается =" + otvet);
            }
        }
    }
}
