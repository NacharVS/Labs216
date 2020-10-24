using System;

namespace Labs216
{
    class DivisionByIntrval
    {
        private static int x;

        private static void Main(string[] args)
        {
          Console.WriteLine("Введите число");
          double a = double.Parse(Console.ReadLine());
          Console.WriteLine("Введите длину интервала");
          double b = double.Parse(Console.ReadLine());
          Console.WriteLine("Введите конечное число интервала");
          double c = double.Parse(Console.ReadLine());
            for (double x = b; x <= c; x++);
            {
                if (x != 0)
                {
                    double y = a / x;
                    Console.WriteLine("$ (a / x = y)");
                }
            }    
        }
    }
}

namespace Labs216
{
    class DivisionByInterval2
    //Square formula
    //Pythagorean theorem
    //circumFerence
    //area of a circle
    //parallepiped's Volume
    //amperage/resistence/voltage
    {
        static void Main(string[] args) 
        { 
        double a = Console.ReadLine("Введите число 1");
        double b = Console.ReadLine("Введите число 2");
        double c = Console.ReadLine("Введите число 3");
        double R = Console.ReadLine("Введите число 4");
        
           double  //FirstValue, SecoundeValue, ThirdValue;
        string action;
        Console.WriteLine("Введите число");
           FirsteValue = double.Parse(Console.ReadLine());
        Console.Write.Line("Введите число ");
           SecoundeValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введиете формулу: ('a^2 = b^2+c^2' 'c^2 = a^2+b^2' '2PI*R^2' 'PI*R^2' 'A*B*C'))

                   action = Console.ReadLine()); 

              switch(action)
                {
                  case "a^2 = b^2+c^2";
                   Console.WriteLine("$a^2 = b^2+c^2");
                    break;
                  case "c^2 = a^2+b^2";
                   Console.WriteLine("$c^2 = a^2+b^2 ");
                    break;
                  case "2PI*R^2";
                   Console.WriteLine("2PI*R^2");
                    break;
                  case "PI*R^2";
                   Console.WriteLine("$ PI*R^2");
                    break;
                  case "A*B*C";
                   Console.WriteLine("A*B*C");
                    break;
                  defoult:
                   Console.WriteLine("Ошибка!")
                }
        }
    }
}