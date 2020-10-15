using System;

namespace Labs216.MikhalevVL
{
    class DivisionByInterval
    {

        static public void DivisionbyInterval()
        {
            Console.Write("Enter a ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter interval: from ");
            double interval_starts = double.Parse(Console.ReadLine());
            Console.Write(" to ");
            double interval_ends = double.Parse(Console.ReadLine());
            if (interval_ends < interval_starts)
            {
                Console.WriteLine("Incorrect values");
            }
            else
            {
                for (double i = interval_starts; i < interval_ends + 1; i++)
                {
                    if (i != 0)
                    {
                        double result = a / i;
                        Console.WriteLine($"Division a by number {i} from interval ({interval_starts} ; {interval_ends}) = {result}");
                    }
                    else if (i == 0)
                    {
                        Console.WriteLine("Cannot be divided by zero");
                    }

                }
            }
        }
    }
}
