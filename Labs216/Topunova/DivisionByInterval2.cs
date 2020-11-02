using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Topunova
{
    class DivisionByInterval2
    {
        //square formula
        //Pythagorean theorem
        //cicrumFerence
        //area of a circle 
        //parallepiped's volume
        //amperage/resistence/voltage


        static void Main(string[] args)
        {
            double a = Console.ReadLine("Введите число 1");
            double b = Console.ReadLine("Введите число 2");
            double c = Console.ReadLine("Введите число 3");
            double d = Console.ReadLine("Введите число 4");
            string action;
            Console.WriteLine("Введите число");
            firsteValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            SecoundeValue = double.Parse(Console.ReadLine());
            Console.WriteLine( "Введите формулу: ('a^2 = b^2 + c^2' 'c^2 = a^2 + b^2' '2PI*R^2' 'PI*R^2' A*B*C'));
                
                switch(action)
            {
                case "a^2 = b^2 + c^2;
                    Console.WriteLin($a2=b^2+c^2");
                    break;
                case "c^2=a^2+b^2;
                    Console.WriteLine($"c^2=a^2+b^2");
                    break;
                case("2PI*R^2");
                    Console.WriteLine($"2PI*R^2");
                    break;
                case ("A*B*C");
                    Console.WriteLine("A*B*C");
                    break;
                defoult;
                    Console.WriteLine("Ошибка")
            }

                 
        }
    }
}
