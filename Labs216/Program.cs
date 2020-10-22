using System;

namespace Labs216
{
    class DivisionByIntrval
    {
        static void Main(string[] args)
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
        static public void Main(string[] args);
        {
           double FirstValue, SecoundeValue, ThirdValue; 
           string action;
           Console.WriteLine("Введите число 1");
           FirsteValue = double.Parse(Console.ReadLine());
           Console.Write.Line("Введите число 2");
           SecoundeValue = double.Parse(Console.ReadLine());
           Console.WriteLine("Введиете формулу: 'a^2 = b^2+c^2' 'c^2 = a^2+b^2' '2PI*R^2' 'PI*R^2' 'A*B*C');
           action = Console.ReadLine()); 

              switch(action)
                {
        }
    }
}