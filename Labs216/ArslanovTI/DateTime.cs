using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.ArslanovTI
{
    class DateTime
    {
        public void Date(string[] args)
        {
            Console.WriteLine("Введите ваш год рождения!");
            int a = int.Parse(Console.ReadLine());
            int b = System.DateTime.Now.Year;
            int age = b - a;
            if (age < 14)
            {
                Console.WriteLine("Малой ещё");

            }
            else
            {
                Console.WriteLine("$Поздравляю, вам", age, "лет, и вы можете открыть счет в нашем банке");
            }
        }
    }
}
