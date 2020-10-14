using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.MikhalevVL
{
    class _1lab
    {
        static void main_from_lab1()
        {
            Console.WriteLine("What do you want to do?: 1. ax^2 - bx + c; 2. c^2 = a^2 + b^2; 3. Circumference; 4. Area of a circle; 5. Parallelepiped's Volume; 6.Amperage/Resistance/Voltage");
            int choiceOfUser = int.Parse(Console.ReadLine());
            switch (choiceOfUser)
            {
                case 1:
                    Dis();
                    break;
                case 2:
                    Sq();
                    break;
                case 3:
                    Circumference();
                    break;
                case 4:
                    AreaOfCircle();
                    break;
                case 5:
                    Volume();
                    break;
                case 6:
                    Physic();
                    break;
            }

        }
        static void Dis()
        {
            Console.Write("Enter а ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter x ");
            int x = int.Parse(Console.ReadLine());
            long xSqrt = (long)Math.Pow(x, 2);
            long result = (a * xSqrt) - (b * x) + c;
            Console.WriteLine($"ax^2 - bx + c = {result}");
        }
        static void Sq()
        {
            Console.Write("Enter а ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c ");
            int c = int.Parse(Console.ReadLine());
            int result_one = (int)Math.Pow(c, 2);
            int result_two = (int)Math.Pow(a, 2) + (int)Math.Pow(b, 2);
            if (result_one == result_two)
            {
                Console.WriteLine("c^2 = a^2 + b^2");
            }
            else Console.WriteLine("c^2 != a^2 + b^2");
        }
        static void Circumference()
        {
            string Separator = " ";
            int isthisend = 0;
            while (isthisend == 0)
            {

                Console.Write("Enter radius or diameter (Example: 20 r (for radius) and 20 d (for diameter)) -- ");
                string choice = Console.ReadLine();
                if (choice.Contains("r") || choice.Contains("R"))
                {
                    var choicearray = choice.Split(Separator);
                    var circumference = double.Parse(choicearray[0]) * 2 * Math.PI;
                    Console.WriteLine($"Circumference of circle with r = {choicearray[0]} — {circumference}");
                    isthisend = 1;
                }
                else if (choice.Contains("d") || choice.Contains("D"))
                {
                    var choicearray = choice.Split(Separator);
                    isthisend = 1;
                    var circumference = double.Parse(choicearray[0]) * Math.PI;
                    Console.WriteLine($"Circumference of circle with d = {choicearray[0]} — {circumference}");
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }
            }

        }
        static void AreaOfCircle()
        {
            Console.Write("Enter radius of circle");
            double radius = double.Parse(Console.ReadLine());
            var area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine($"Area of a circle with radius = {radius} — {area}");
        }
        static void Volume()
        {
            Console.Write("Enter a - length b - width and c - height (For example: 20 30 10)");
            string values = Console.ReadLine();
            string Separator = " ";
            var valuesarray = values.Split(Separator);
            int volume = int.Parse(valuesarray[0]) * int.Parse(valuesarray[1]) * int.Parse(valuesarray[2]);
            Console.WriteLine("Parallelepiped's volume = " + volume);
        }
        static void Physic()
        {
            Console.Write("Enter what you want to find (1.Amperage) (2.Resistance) (3.Voltage)");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Ener other values. 1.Resistance 2.Voltage. For example (2 3)");
                    string values_vr = Console.ReadLine();
                    string[] valuesarray_vr = values_vr.Split(" ");
                    var amper = int.Parse(valuesarray_vr[1]) / int.Parse(valuesarray_vr[0]);
                    Console.WriteLine("Amperage = " + amper);
                    break;
                case 2:
                    Console.Write("Ener other values. 1.Amperage 2.Voltage. For example (2 3)");
                    string values_av = Console.ReadLine();
                    string[] valuesarray_av = values_av.Split(" ");
                    var ohm = int.Parse(valuesarray_av[1]) / int.Parse(valuesarray_av[0]);
                    Console.WriteLine("Resistance = " + ohm);
                    break;
                case 3:
                    Console.Write("Ener other values. 1.Resistance 2.Amperage. For example (2 3)");
                    string values_ra = Console.ReadLine();
                    var valuesarray_ra = values_ra.Split(" ");
                    var voltage = int.Parse(valuesarray_ra[1]) * int.Parse(valuesarray_ra[0]);
                    Console.WriteLine("Voltage = " + voltage);
                    break;
            }
        }
    }
}
