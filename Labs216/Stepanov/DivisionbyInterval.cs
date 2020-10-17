using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Stepanov
{
    class DivisionbyInterval
    {

        static public void DivisionByInterval()
        {
            Console.WriteLine("Enter number");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter begin interval");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter end intrerval");
            double second = double.Parse(Console.ReadLine());

            for(double i = first; i <= second; i++)
            {
                if (i == 0) continue;
                double devision = number / i;
                Console.WriteLine($"Division result {number} by {i} = {devision} ");               
            }
        }
    }   
}
        
    

    

